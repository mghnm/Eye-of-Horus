using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float jmpforce = 5;
    public float maxvelocity = 10f;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool grounded;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate() {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 mov = new Vector2(moveHorizontal * 5, 0.0f);

        if (rb2d.velocity.magnitude < maxvelocity)
        {
            rb2d.AddForce(mov);


        }


    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space") && grounded)
        {

            Vector2 jmp = new Vector2(0.0f, jmpforce);

            rb2d.AddForce(jmp, ForceMode2D.Impulse);


        }


        if (Input.GetKey("escape"))
        {

            Application.Quit();


        }

       

    }
}
