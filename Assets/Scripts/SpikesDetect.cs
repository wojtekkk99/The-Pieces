using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDetect : MonoBehaviour
{
    GameObject Player;
    public AudioSource audio;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spikes")
        {
            Player.GetComponent<Hearts>().health -= 1;
            if (Player.GetComponent<Hearts>().health == 0)
            {
                Player.GetComponent<Hearts>().Die();
                audio.Play();
            }
            else
            {
                Player.transform.position = Player.gameObject.GetComponent<Hearts>().lastCheckpoint;
                audio.Play();
            }
        }
    }
}

