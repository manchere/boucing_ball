using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raquette : MonoBehaviour
{
    public float speed;
    public float clampX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -30f, 30f);
        transform.position = pos;
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }
}
