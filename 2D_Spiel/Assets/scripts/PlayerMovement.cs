using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using static PlayerMovement;
using static Attack;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 rotation;
    public CharacterController2D controller;
    public float MovementSpeed = 1.0f;
    public float JumpHigh = 1.0f;
    public float jumpTakeOffSpeed = 7;
    private Vector3 respawnPoint;

    public Camera playerCamera;
    public Animator animator;
    private bool stopJump;
    public Collider2D collider2d;

    private CoinCounter m;
    public GameObject ESCpanel;
    public GameObject panel;

    public bool jump;
    float esc;

    SpriteRenderer spriteRenderer;
    Rigidbody2D Rb;

    // Start is called before the first frame update
    void Start()
    {
        esc = 1;
        Rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        m = GameObject.FindGameObjectWithTag("Text").GetComponent<CoinCounter>();
        respawnPoint = transform.position;
        rotation = transform.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move;
        
        
        // Left/Right Movement
        move.x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move.x, 0, 0) * Time.deltaTime * MovementSpeed;

        //Animation
        animator.SetFloat("Speed", Mathf.Abs(move.x));

        // Jumping
        if (Input.GetButton("Jump") && Mathf.Abs(Rb.velocity.y) < 0.0001f)
        {
            Rb.AddForce(new Vector2(0, JumpHigh), ForceMode2D.Impulse);
            jump = true;
        }

        if(move.x < -0.01f)
        {
            transform.eulerAngles = rotation - new Vector3(0, 180, 0);
        }

        if(move.x > 0.01f)
        {
            transform.eulerAngles = rotation;
        }






        if (Input.GetKeyDown("t"))
        {
            
            esc = esc + 1;

            ESCpanel.SetActive(true);
            if (esc % 2 == 0 )
            {
                ESCpanel.SetActive(true);
                Debug.Log (esc%2);
            }
            
            else 
            {
                ESCpanel.SetActive(false);
            }



    }


    }
     private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Coin")
            {
                m.Addmoney();
                Destroy(other.gameObject);
            }

            if (other.tag == "Checkpoint")
            {
                respawnPoint = transform.position;
            }

            if (other.tag == "Zone_Restart")
            {
                transform.position = respawnPoint ;
            }

     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy" && jump == false)
        {
            transform.position = respawnPoint;
        }

        else if (collision.gameObject.tag == "Enemy")
        {
            transform.position = respawnPoint;
        }

        if (collision.gameObject.tag == "Ende")
            {
                panel.SetActive(true);
                Destroy(gameObject);
            }

        if (collision.gameObject.tag == "Ground")
        {
            jump = false;
        }

    }
   
}
