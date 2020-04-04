using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInfo : MonoBehaviour
{
    public GameObject info;
    public AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (info != null)
            {
                info.gameObject.SetActive(true);
                audio.Play();
                info.GetComponent<Animator>().Play("CheckInfo");
            }
        }
    }
}
