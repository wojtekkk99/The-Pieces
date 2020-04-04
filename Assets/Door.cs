using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public PlayerMovement player;
    public void Destroy()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (player.hasKey)
            {
                player.hasKey = false;
                GetComponent<Animator>().Play("OpenDoor");
            }
        }
    }
}
