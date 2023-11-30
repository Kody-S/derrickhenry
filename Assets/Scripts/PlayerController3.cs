using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.UI;

public class PlayerController3 : MonoBehaviour
{
    GameManager gameManager;
    public Rigidbody theRB;
    public float moveSpeed, jumpForce;

    private Vector2 moveInput;

    public LayerMask whatIsGround;
    public Transform groundPoint;
    private bool isGrounded;
    public bool hasFootball;
    public bool hasGatorade;
    public bool hasPepsi;
    public GameObject footballIndicator;
    private bool gameOver = false;
    public float gatoradeSpeed;
    public float pepsiSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
            //StartCoroutine(PowerupCountdownRoutine());
        }
        if (other.CompareTag("Pepsi")){
            hasPepsi = true;
            theRB.velocity = new Vector3(moveInput.x * moveSpeed + pepsiSpeed, theRB.velocity.y, moveInput.y * moveSpeed + pepsiSpeed);
            pepsiSpeed = moveSpeed - 2;
            moveSpeed = pepsiSpeed;
            Destroy(other.gameObject);
            //StartCoroutine(PowerupCountdownRoutine());
        }
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Enemy") && hasFootball){
            Debug.Log("Collided with " + collision.gameObject.name + " with football " + hasFootball);
            gameOver = true;
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 80);
        }

    }

}