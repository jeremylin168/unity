using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    private Quaternion targetRotation;


    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //rigidBody.velocity = Vector2.zero;
        //if (Input.GetKey(KeyCode.W))
        //transform.position += (Vector3.up * Time.deltaTime * 1f);
        //rigidBody.velocity += Vector2.up;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * Time.deltaTime * 2f);
            //transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            //rigidBody.velocity += Vector2.left;
        }

        //if (Input.GetKey(KeyCode.S))
        //transform.position += (Vector3.down * Time.deltaTime * 1f);
        //rigidBody.velocity += Vector2.down;
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * Time.deltaTime * 2f);
            //transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            //rigidBody.velocity += Vector2.right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (Vector3.up * Time.deltaTime * 2f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (Vector3.down * Time.deltaTime * 2f);
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 7f;
            rigidBody.velocity = Vector2.up * jumpVelocity;
            //isGrounded = false;
        }*/
    }



}
