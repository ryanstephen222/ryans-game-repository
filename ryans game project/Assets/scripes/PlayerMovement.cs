using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementforce = 10f;

    public float jumpforce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();


            ourRigidbody.AddForce(Vector2.right * movementforce);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();


            ourRigidbody.AddForce(Vector2.left * movementforce);
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();


            ourRigidbody.AddForce(Vector2.up * jumpforce);
        }



    }



}
