using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrolar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Fixedupdate is used when modifying physics value
    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz=Input.GetAxis("Horizontal");
        float vert= Input.GetAxis("Vertical");

       // Debug.Log("Horizontal: " + horiz);
       Rigidbody2D rbody= GetComponent<Rigidbody2D>();
       

    }
}
