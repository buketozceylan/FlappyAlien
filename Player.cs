using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 2.4f;
    private Rigidbody2D rigid;
    public GameManager gameManager;
    public bool isDead = false;
    private Animator anim;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "ColumnUp" || collision.transform.name == "ColumnDown" || collision.transform.name == "Platform" )
        {
            isDead = true;
            gameManager.GameOver();
        }
    }
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){

            anim.SetTrigger("Click");
            rigid.velocity = Vector2.up * velocity;
            

        }
    }
}
