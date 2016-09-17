using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private EdgeCollider2D playerCollider;
    private Vector3 mousePos;
    private float actualSpeed = 0f;
    private Rigidbody2D playerRig;
    private Vector3 LastPosition;

    public float moveSpeed = 0.1f;
    public float maxMoveSpeed = 1f;
    public float turnSpeed = 1f;
    public float incrementMoveSpeed = 0.001f;

    

	// Use this for initialization
	void Start () {
        playerCollider = GetComponent<EdgeCollider2D>();
        playerRig = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1)) { //se pressionado botao direito do mouse
            mousePos = Input.mousePosition; //pega posisao x e y do mouse
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); 

            Vector3 vectorToTarget = mousePos - transform.position; //distancia da nave pro mouse
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg; // angulo de diferença
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); // Quartenion é o Objeto de transformação em graus
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turnSpeed); // gire o objeto conforme o mouse na velocidade turnSpeed

            if (actualSpeed < maxMoveSpeed && Vector3.Distance(transform.position, mousePos) > 10.5 ) { // Se velocidade não chegou ao maximo e mouse está numa distancia maior que 10.06
                actualSpeed += incrementMoveSpeed; // incrementa velocidade da nave
            }


            
            transform.position = Vector2.Lerp(transform.position, mousePos, actualSpeed); // atualiza posição da nave

            float speed = (transform.position - LastPosition).magnitude / Time.deltaTime; // pega velocidade real do objeto
            LastPosition = transform.position;
            
            if (actualSpeed > 0 && (speed <= 5 && Vector3.Distance(transform.position, mousePos) <= 10)) // caso clique e fique com o mouse parado no mesmo lugar diminui a velocidade ao chegar perto do mouse
            {
                actualSpeed -= incrementMoveSpeed;
            }
            else if (speed <= 10 && Vector3.Distance(transform.position, mousePos) <= 10.05) // se chegar muito perto do mouse zera a velocidade
                actualSpeed = 0;

        }
        else{// caso não esteja clicnado com o mouse 
            if (actualSpeed > 0) { // se velocidade atual for maior que zero
                
                actualSpeed -= incrementMoveSpeed; //diminui velocidade aos poucos
                transform.position = Vector2.Lerp(transform.position, mousePos, actualSpeed); // movimentação da nave

                if (playerRig.velocity.x <= 0 && playerRig.velocity.y <= 0 && Vector3.Distance(transform.position, mousePos) <= 10) // caso não esteja clicando com o mouse e nave esteja parada
                    actualSpeed = 0;
            }
        }
	
	}



}
