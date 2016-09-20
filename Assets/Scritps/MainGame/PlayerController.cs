using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public AudioClip jatinhoSound;
    public AudioClip imaSound;
    public AudioClip collisionSound;

    private EdgeCollider2D playerCollider;
    private Vector3 mousePos;
    private float actualSpeed = 0f;
    private Rigidbody2D playerRig;
    private Vector3 LastPosition;
    private float speed;
    private ParticleSystem.EmissionModule jatinhoemit;
    private ParticleSystem.EmissionModule atracaoemit;
    private ParticleSystem.EmissionModule repulsaoemit;
    private bool tutorial;
    public static bool animation = true;
    public static bool fazendoTutorial = false;

    public GameObject dialog;
    public ParticleSystem jatinho;
    public ParticleSystem atracao;
    public ParticleSystem repulsao;
    public float moveSpeed = 0.1f;
    public float maxMoveSpeed = 1f;
    public float turnSpeed = 1f;
    public float incrementMoveSpeed = 0.001f;


    public Vector3 posInitial;
    private AudioSource audioJet;
    private AudioSource audioIma;

    public bool isDead = false;

    public Sprite spaceShip;
    public Sprite destroiedSpaceShip;
    public SpriteRenderer render;

    void Awake(){
        animation = true;
        fazendoTutorial = false;
        isDead = false;
    }

    // Use this for initialization
    void Start()
    {
        posInitial = transform.position;
        if(Application.loadedLevelName == "MainGame")
            transform.position = new Vector3(-12, 0, 0);

        audioJet = GetComponent<AudioSource>();
        playerCollider = GetComponent<EdgeCollider2D>();
        playerRig = GetComponent<Rigidbody2D>();
        jatinhoemit = jatinho.emission;
        atracaoemit = atracao.emission;
        repulsaoemit = repulsao.emission;

        if (jatinho.isPlaying)
            jatinho.Stop();
        if (atracao.isPlaying)
            atracao.Stop();
        if (repulsao.isPlaying)
            repulsao.Stop();

    }

    // Update is called once per frame
    void Update()
    {
            
        tutorial = DialogController.tutorial;
        if (Application.loadedLevelName != "MainGame")
            animation = false;

        if (isDead)
        {
            return;
        }

        if (animation)
        {

            if (!jatinho.isPlaying)
            {
                jatinho.Simulate(0.0f, true, true);
                jatinhoemit.enabled = true;
                jatinho.Play();
                if (!audioJet.isPlaying)
                {
                    audioJet.loop = true;
                    audioJet.clip = jatinhoSound;
                    audioJet.Play();
                }

            }

            transform.position = Vector2.Lerp(transform.position, new Vector3(-1, 0, 0), 0.01f);

            if (transform.position.x >= -1.2)
            {
                if (jatinho.isPlaying)
                {
                    jatinhoemit.enabled = false;
                    jatinho.Stop();
                    audioJet.Stop();
                }
                animation = false;
                dialog.SetActive(true);
            }

            

        }
        else if (!tutorial || DialogController.tutorialEnd)
        {
            #region Tutorial
            if (fazendoTutorial)
            {
                if (Time.realtimeSinceStartup - DialogController.lastChange > 10)
                {
                    fazendoTutorial = false;
                    DialogController.tutorial = true;
                }


            }
            #endregion

            #region Movimento Nave / Mouse
            mousePos = Input.mousePosition; //pega posisao x e y do mouse
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3 vectorToTarget = mousePos - transform.position; //distancia da nave pro mouse
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg; // angulo de diferença
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); // Quartenion é o Objeto de transformação em graus
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turnSpeed); // gire o objeto conforme o mouse na velocidade turnSpeed

            #endregion

            #region Movimento/Botao direito

            if (Input.GetMouseButton(1))
            { //se pressionado botao direito do mouse
                if (!audioJet.isPlaying)
                {
                    audioJet.loop = true;
                    audioJet.clip = jatinhoSound;
                    audioJet.Play();
                }
                if (!jatinho.isPlaying)
                {
                    jatinho.Simulate(0.0f, true, true);
                    jatinhoemit.enabled = true;
                    jatinho.Play();
                    if (!audioJet.isPlaying)
                    {
                        audioJet.loop = true;
                        audioJet.clip = jatinhoSound;
                        audioJet.Play();
                    }

                }

                if (actualSpeed < maxMoveSpeed && Vector3.Distance(transform.position, mousePos) > 2.5)
                { // Se velocidade não chegou ao maximo e mouse está numa distancia maior que 10.06
                    actualSpeed += incrementMoveSpeed; // incrementa velocidade da nave
                }
                transform.position = Vector2.Lerp(transform.position, mousePos, actualSpeed); // atualiza posição da nave

                speed = (transform.position - LastPosition).magnitude / Time.deltaTime; // pega velocidade real do objeto
                LastPosition = transform.position;

                if (actualSpeed > 0 && (speed <= 5 && Vector3.Distance(transform.position, mousePos) <= 10)) // caso clique e fique com o mouse parado no mesmo lugar diminui a velocidade ao chegar perto do mouse
                {
                    actualSpeed -= incrementMoveSpeed;
                }
                else if (speed <= 10 && Vector3.Distance(transform.position, mousePos) <= 4.05) // se chegar muito perto do mouse zera a velocidade
                    actualSpeed = 0;

            }
            else
            {// caso não esteja clicnado com o mouse 
                if (jatinho.isPlaying)
                {
                    jatinhoemit.enabled = false;
                    jatinho.Stop();

                }
                if (actualSpeed > 0)
                { // se velocidade atual for maior que zero

                    actualSpeed -= incrementMoveSpeed; //diminui velocidade aos poucos
                    transform.position = Vector2.Lerp(transform.position, mousePos, actualSpeed); // movimentação da nave

                    if (playerRig.velocity.x <= 0 && playerRig.velocity.y <= 0 && Vector3.Distance(transform.position, mousePos) <= 10) // caso não esteja clicando com o mouse e nave esteja parada
                        actualSpeed = 0;
                }

            }
            if (Input.GetMouseButtonUp(1))
            {
                audioJet.Stop();
            }

            #endregion
            
            if (Input.GetMouseButtonUp(0))
            {
                audioJet.Stop();
            }
            if (Input.GetMouseButton(0))
            {
                if (!audioJet.isPlaying)
                {
                    audioJet.clip = imaSound;
                    audioJet.loop = true;
                    audioJet.Play();
                }

                onClickLeftMouseButton();
            }
            else
            {
                if (atracao.isPlaying)
                {
                    atracaoemit.enabled = false;
                    atracao.Stop();
                }
                if (repulsao.isPlaying)
                {
                    repulsaoemit.enabled = false;
                    repulsao.Stop();
                }
            }
        }

    }

    void onClickLeftMouseButton()
    {



        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (!repulsao.isPlaying)
            {
                repulsao.Simulate(0.0f, true, true);
                repulsaoemit.enabled = true;
                repulsao.Play();
            }
        }
        else
        {
            if (!atracao.isPlaying)
            {
                atracao.Simulate(0.0f, true, true);
                atracaoemit.enabled = true;
                atracao.Play();
            }
        }
        List<Transform> bombsList = findBombsByNearst();

        if (bombsList.Count() > 0)
        {

            foreach (Transform bombTransform in bombsList)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    repelBomb(bombTransform);
                }
                else
                {
                    attractBomb(bombTransform);
                }

            }

        }
    }

    List<Transform> findBombsByNearst()
    {
        return GameObject.FindGameObjectsWithTag("bomb")
            .Select(go => go.transform)
            .Where(tBomb => Vector3.Distance(transform.position, tBomb.position) < 6f)
            .ToList();

    }

    void attractBomb(Transform bomb)
    {
        Vector3 offset = transform.position - bomb.position;

        Rigidbody2D objRigid = bomb.GetComponent<Rigidbody2D>();

        objRigid.AddForce(0.001f * offset);
        objRigid.velocity = Vector2.ClampMagnitude(objRigid.velocity, 0.5f);

    }

    void repelBomb(Transform bomb)
    {
        Vector3 offset = bomb.position - transform.position;

        Rigidbody2D objRigid = bomb.GetComponent<Rigidbody2D>();

        objRigid.AddForce(0.001f * offset);
        objRigid.velocity = Vector2.ClampMagnitude(objRigid.velocity, 0.5f);

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "scenario" || collision.gameObject.tag != "finish")
        {
            
            DeathControler player = GetComponent<DeathControler>();
            isDead = true;

            jatinho.Stop();
            audioJet.Stop();
            repulsao.Stop();
            atracao.Stop();
            actualSpeed = 0f;
        }
        else if (collision.gameObject.tag == "goal")
            transform.position = posInitial;
        else
        {

        }

    }

    public void restart() {
        Application.LoadLevel(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
