using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPick : MonoBehaviour
{
    public GameObject Screen;
    public PlayerMovement player;
    public AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Screen.transform.Find("Key").gameObject.SetActive(true);
            player.hasKey = true;
            audio.Play();
            Destroy(gameObject);
        }
    }
}
