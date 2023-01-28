using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using static PlayerMovement;

public class PlayerMovement : MonoBehaviour
{

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

    public GameObject panel;

    SpriteRenderer spriteRenderer;
    Rigidbody2D Rb;

    // Start is called before the first frame update
    void Start()
    {

        Rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        m = GameObject.FindGameObjectWithTag("Text").GetComponent<CoinCounter>();
        respawnPoint = transform.position;

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

        }


        if (move.x > 0.01f)
            spriteRenderer.flipX = false;
        else if (move.x < -0.01f)
            spriteRenderer.flipX = true;

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
        
        if (collision.gameObject.tag == "Enemy")
        {
            transform.position = respawnPoint;
        }

        if (collision.gameObject.tag == "Ende")
            {
                panel.SetActive(true);
                Destroy(gameObject);
            }

    }
   





}
