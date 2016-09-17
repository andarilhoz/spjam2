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
        if (Input.GetMouseButton(1)) {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3 vectorToTarget = mousePos - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turnSpeed);

            if (actualSpeed < maxMoveSpeed && Vector3.Distance(transform.position, mousePos) > 10.5 ) {
                actualSpeed += incrementMoveSpeed;
            }


            
            transform.position = Vector2.Lerp(transform.position, mousePos, actualSpeed);

            float speed = (transform.position - LastPosition).magnitude / Time.deltaTime;
            LastPosition = transform.position;

            Debug.Log(Vector3.Distance(transform.position, mousePos));
            if (actualSpeed > 0 && (speed <= 5 && Vector3.Distance(transform.position, mousePos) <= 10))
            {
                actualSpeed -= incrementMoveSpeed;
            }
            else if (speed <= 10 && Vector3.Distance(transform.position, mousePos) <= 10.05)
                actualSpeed = 0;

        }
        else{
            if (actualSpeed > 0) {
                
                actualSpeed -= incrementMoveSpeed;
                transform.position = Vector2.Lerp(transform.position, mousePos, actualSpeed);

                if (playerRig.velocity.x <= 0 && playerRig.velocity.y <= 0 && Vector3.Distance(transform.position, mousePos) <= 10)
                    actualSpeed = 0;
            }
        }
	
	}
}
