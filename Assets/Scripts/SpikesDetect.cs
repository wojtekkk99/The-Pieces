using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDetect : MonoBehaviour
{
    GameObject Player;
    public GameObject Checkpoint;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Checkpoint = GameObject.FindGameObjectWithTag("Checkpoint");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Spikes")
        {
            Player.GetComponent<Hearts>().health -= 1;
            Player.transform.position = Checkpoint.transform.position;
        }
    }
}

