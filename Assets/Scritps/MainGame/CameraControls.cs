using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {

    
    private Vector3 offset;  

    
    void Start () 
    {   
        offset = transform.position - GameObject.FindGameObjectWithTag("spaceship").transform.position;
    }
    
    void LateUpdate () 
    {   
        transform.position = GameObject.FindGameObjectWithTag("spaceship").transform.position + offset;
    }
}