using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public int health = 5;
    private Animator anim;
    private AudioSource audioSource;
    public AudioClip hurtSound;
    public AudioClip breakSound;
    private SpriteRenderer sprite;
    private Collider2D collider;
    [SerializeField] private RecoveryCounter recoveryCounter;

    // Start is called before the first frame update
    void Start()
    {
        recoveryCounter = GetComponent<RecoveryCounter>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player Attack"))
        {
            if (health == 1)
            {
                audioSource.PlayOneShot(breakSound);

                //Destroy(gameObject);
                anim.enabled = false;
                sprite.enabled = false;
                collider.enabled = false;
            }
            audioSource.PlayOneShot(hurtSound);
            anim.SetTrigger("hurt");
            health -= 1;
            recoveryCounter.counter = 0;
        }
    }

/*    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player Attack"))
        {
            audioSource.PlayOneShot(hurtSound);
            anim.SetTrigger("hurt");
            health -= 1;
            recoveryCounter.counter = 0;
        }
    }*/
}
