using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balle : MonoBehaviour
{
    public Vector3 deplacement;
    public int nbrBriques;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = deplacement;
    }

    void OnCollisionEnter(Collision collision){
        deplacement = Vector3.Reflect(deplacement, collision.contacts[0].normal);

        if (collision.gameObject.tag == "Brique")
        {
            Destroy(collision.gameObject);
        }
    }
} 
