using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Hearts : MonoBehaviour
{
    public int health;
    public GameObject levelBegin;
    public Vector3 lastCheckpoint;
    public Image[] hearts;
    public Rigidbody2D rigid;
    public Sprite OneHeart;
    public GameObject gameOver;

    void Start()
    {
        lastCheckpoint = levelBegin.transform.position;
    }

        // Update is called once per frame
        void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if(health == 0)
        {
            Die();
        }
    }
    
    public void Die()
    {
        health = 3;
        rigid.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<PlayerMovement>().IsFreeze = true; 
        gameOver.SetActive(true);
        gameOver.GetComponent<Animator>().Play("GameOverDark");
    }

  
}
