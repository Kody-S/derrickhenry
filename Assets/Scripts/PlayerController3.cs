using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.UI;

public class PlayerController3 : MonoBehaviour
{
    //Enemy enemyScript;
    GameManager gameManager;
    public Rigidbody theRB;
    public float moveSpeed, jumpForce;
    public ParticleSystem explosionParticle;

// :3 - nolan
    private Vector2 moveInput;

    public LayerMask whatIsGround;
    public Transform groundPoint;
    private bool isGrounded;
    public bool hasFootball;
    public bool hasGatorade;
    public bool hasPepsi;
    public bool hasSprite;
    public GameObject footballIndicator;
    private bool gameOver = false;
    public float gatoradeSpeed;
    public float pepsiSpeed;
    public AudioClip collectSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        theRB.velocity = new Vector3(moveInput.x * moveSpeed, theRB.velocity.y, moveInput.y * moveSpeed);
    
        RaycastHit hit;
        if(Physics.Raycast(groundPoint.position, Vector3.down, out hit, .2f, whatIsGround)){
            isGrounded = true;
        }
        else{
            isGrounded = false;
        }

        if(Input.GetButtonDown("Jump") && isGrounded){
            theRB.velocity += new Vector3(0f, jumpForce, 0f);
        }
        footballIndicator.transform.position = transform.position + new Vector3(0.4f, 0f, 0f);
       
    }

    public void OnTriggerEnter(Collider other){
        if (other.CompareTag("Football")){
            hasFootball = true;
            Destroy(other.gameObject);
            footballIndicator.gameObject.SetActive(true);
            }
        if (other.CompareTag("Gatorade")){
            hasGatorade = true;
            theRB.velocity = new Vector3(moveInput.x * moveSpeed + gatoradeSpeed, theRB.velocity.y, moveInput.y * moveSpeed + gatoradeSpeed);
            gatoradeSpeed = moveSpeed + 2;
            moveSpeed = gatoradeSpeed;
            Destroy(other.gameObject);
            //StartCoroutine(GatoradeCountdownRoutine());
            playerAudio.PlayOneShot(collectSound, 1.0f);
        }
        if (other.CompareTag("Pepsi")){
            hasPepsi = true;
            theRB.velocity = new Vector3(moveInput.x * moveSpeed + pepsiSpeed, theRB.velocity.y, moveInput.y * moveSpeed + pepsiSpeed);
            pepsiSpeed = moveSpeed - 2;
            moveSpeed = pepsiSpeed;
            Destroy(other.gameObject);
            //StartCoroutine(PepsiCountdownRoutine());
            playerAudio.PlayOneShot(collectSound, 1.0f);

        }

        if (other.CompareTag("Sprite")){
            hasSprite = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            playerAudio.PlayOneShot(collectSound, 1.0f);
        }

        if (other.gameObject.CompareTag("Pepsi") &! hasFootball){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 88);
        }

        if (other.gameObject.CompareTag("Gatorade") &! hasFootball){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 88);
        }

        if (other.gameObject.CompareTag("Sprite") &! hasFootball){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 88);
        }
    }

    IEnumerator PowerupCountdownRoutine(){
        hasSprite = false;
        theRB.isKinematic = true;
        // Enemy enemyScript = collision.gameObject.GetComponent<Enemy>();
        // enemyScript.enemyRb.isKinematic = true;
        yield return new WaitForSeconds(3);
        theRB.isKinematic = false;
        // enemyScript.enemyRb.isKinematic = false;
    }

    IEnumerator ParticleCountdownRoutine(){
        // figure out how to have explosion particle play for only a couple seconds and then have the you lose cover appear
        explosionParticle.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 80);
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Enemy") && hasFootball){
            Debug.Log("Collided with " + collision.gameObject.name + " with football " + hasFootball);
            theRB.isKinematic = true;
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.enemyRb.isKinematic = true;
            StartCoroutine(ParticleCountdownRoutine());
            //explosionParticle.Play();
            Debug.Log("Game Over!");
        }

        if (collision.gameObject.CompareTag("Enemy") &! hasFootball){
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 88);
        }

        if (collision.gameObject.CompareTag("Endzone") && hasFootball){
            Debug.Log("You Win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 14);
        }

        if (collision.gameObject.CompareTag("Endzone") &! hasFootball){
            Debug.Log("Nice Try!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 88);
        }

    }

}