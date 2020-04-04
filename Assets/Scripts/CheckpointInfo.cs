using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointInfo : MonoBehaviour
{
    public GameObject info;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            info.gameObject.SetActive(true);
            info.GetComponent<Animator>().Play("CheckInfo");
        }
    }
}
