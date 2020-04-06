using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDetect : MonoBehaviour
{
    GameObject Player;
    public AudioSource hited;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        hited = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spikes")
        {
            Player.GetComponent<Hearts>().health -= 1;
            if (Player.GetComponent<Hearts>().health == 0)
            {
                Player.GetComponent<Hearts>().Die();
                hited.Play();
            }
            else
            {
                Player.transform.position = Player.gameObject.GetComponent<Hearts>().lastCheckpoint;
                hited.Play();
            }
        }
    }
}

