using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_RB : MonoBehaviour
{
    //Variables. Declare your variables.  
    public float forceAmt = 2f;

    private int i = 8;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
     //Find the Rigidbody on the object this script is on
     rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to move right by using D
        if (Input.GetKey(KeyCode.D))
        {
            //Make Ridigbody move right
            rb.AddForce(Vector2.right * forceAmt);
        }
        //Make Ridigbody move left
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceAmt);
        }
    }
}
