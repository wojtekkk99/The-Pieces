using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public LevelChanger levelChanger;
    public GameObject Screen;
    public GameObject Player;
    public int nexLevel;
    public AudioSource audio;
    void Start()
    {
        GetComponent<MovingPlaform>().enabled = false;
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
            audio.Play();
        {
            if (Player.GetComponent<PlayerMovement>().hasGiveKey == true)
            {
                GetComponent<MovingPlaform>().enabled = true;
                transform.Find("BalonKey").gameObject.SetActive(true);
                Screen.transform.Find("Key").gameObject.SetActive(false);
                Player.GetComponent<HealthScore>().SavePlayerBoy();
                levelChanger.FadeToNextLevel(nexLevel);
            }
            else
            {
                transform.Find("ErrorInfo").gameObject.SetActive(true);
                GetComponent<Animator>().Play("ErrorMessage");
            }
        }
    }
}
