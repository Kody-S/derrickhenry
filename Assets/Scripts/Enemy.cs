using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Football Indicator");
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }

    private void GameOver(){
        speed = 0;
    }
}
