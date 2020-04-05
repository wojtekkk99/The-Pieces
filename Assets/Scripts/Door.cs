using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public PlayerMovement player;
    public GameObject Screen;
    public void Destroy()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (player.hasPickKey)
            {
                player.hasPickKey = false;
                Screen.transform.Find("Key").gameObject.SetActive(false);
                GetComponent<Animator>().Play("OpenDoor");
            }
        }
    }
}
