using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chicken : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    float score = 0;
    public bool isDead = false;
    public float jumpForce;
    public TextMeshProUGUI scoreTxt;
    public GameManager gameManager;
    public GameObject deathVFX;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        scoreTxt.text = "" + score;
        if(Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger("Fly");
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Score"){
            score++;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(!isDead){
            Instantiate(deathVFX, transform.position, Quaternion.identity);
            anim.SetTrigger("Hit");
            isDead = true;
        }
        gameManager.GameOver();
    }
}
