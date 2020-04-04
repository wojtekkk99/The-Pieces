using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPick : MonoBehaviour
{
    public GameObject Screen;
    public PlayerMovement player;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Screen.transform.Find("Key").gameObject.SetActive(true);
            player.hasKey = true;
            Destroy(this.gameObject);
        }
    }
}
