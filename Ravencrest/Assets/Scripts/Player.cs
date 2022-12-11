using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalMove;
    public float speed = 10;
    public float dashPower = 40;
    private Rigidbody2D rb;
    public Animator anim;
    private Vector3 origLocalScale;
    public float songVolume = 0.6f;
    private int attackCounter = 1;
    private int faceDir;

    /*    private static Player instance;
        public static Player Instance
        {
            get
            {
                if (instance == null) instance = GameObject.FindObjectOfType<Player>();
                return instance;
            }
        }*/
    // Start is called before the first frame update
    void Start()
    {
        origLocalScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic(songVolume);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        if (horizontalMove > 0.01f)
        {
            transform.localScale = new Vector3(origLocalScale.x, transform.localScale.y, transform.localScale.z);
            faceDir = 1;
        }
        else if (horizontalMove < -0.01f)
        {
            transform.localScale = new Vector3(-origLocalScale.x, transform.localScale.y, transform.localScale.z);
            faceDir = -1;

        }

        anim.SetFloat("moveX", Mathf.Abs(rb.velocity.x));


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isAttacking", true);
            if(attackCounter > 3)
            {
                attackCounter = 1;
            }

            if (attackCounter == 1)
            {  
                anim.SetInteger("attackCounter", attackCounter);
            }

            if (attackCounter == 2)
            {
                anim.SetInteger("attackCounter", attackCounter);
            }

            if (attackCounter == 3)
            {
                anim.SetInteger("attackCounter", attackCounter);
            }

            anim.SetTrigger("attack");
            attackCounter++;
            

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * speed);
            anim.SetFloat("moveY", rb.velocity.y);
            anim.SetTrigger("jump");

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(faceDir == 1)
            {
                rb.AddForce(Vector2.right * speed);
                anim.SetTrigger("dash");
            } else
            {
                rb.AddForce(Vector2.left * speed);
                anim.SetTrigger("dash");
            }
          

        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove * speed * Time.fixedDeltaTime, transform.position.y);
    }
}
