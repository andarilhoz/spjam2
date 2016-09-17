using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]
public class Gravity : MonoBehaviour {
    public float throwForce;
    public float maxVelocity;

    private float speed;
    private Rigidbody2D objRig;
    private Vector3 LastPosition;

    // Use this for initialization
    void Start () {
        objRig = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        speed = (transform.position - LastPosition).magnitude / Time.deltaTime; // pega velocidade real do objeto
        LastPosition = transform.position;
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bomb")
        {
            GameObject obj = col.gameObject;

            var force = transform.position - col.transform.position;
            force.Normalize();

            objRig.AddForce(force * throwForce);

            objRig.velocity = Vector2.ClampMagnitude(objRig.velocity, maxVelocity);

        }
    }

}
