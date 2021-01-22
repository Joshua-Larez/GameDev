using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    public float jumpforce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {

        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;

        //Physics.gravity = Physics.gravity * gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        // when pressing space makes player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound,1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground")) // when player is on floor
        {
            isOnGround = true;
            dirtParticle.Play();
        } 
        else if (collision.gameObject.CompareTag("Obstacle"))   // if player gets hit with obstacle execute statements
        {
            gameOver = true;
            Debug.Log("Game Over !");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();  // makes an animation that explodes
            dirtParticle.Stop();  // makes an animation of dirt at de feet of the player
            playerAudio.PlayOneShot(crashSound, 3.0f);  // when player gets hit with obstacle play this sound
        } 

    }
  
}
