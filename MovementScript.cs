using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{


    //Floats
    public float moveSpeed, sprintSpeed;
    public float jumpForce;    
    private float xInput, yInput, setSpeed;


    //Bools    
    public bool canMove, isSprinting;
    private bool isGrounded;

    //Misc
    Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if (canMove)
        {
            Movement();
        }


    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
            moveSpeed = sprintSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
            moveSpeed = setSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        Vector3 playerMove = new Vector3(xInput, 0, yInput) * moveSpeed * Time.deltaTime;
        transform.Translate(playerMove, Space.Self);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
           
        }

    }
}
