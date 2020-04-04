using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public LevelChanger levelChanger;
    public GameObject Screen;
    public PlayerMovement Player;
    void Start()
    {
        GetComponent<MovingPlaform>().enabled = false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Player.hasKey == true)
            {
                GetComponent<MovingPlaform>().enabled = true;
                transform.Find("BalonKey").gameObject.SetActive(true);
                Screen.transform.Find("Key").gameObject.SetActive(false);
                levelChanger.FadeToNextLevel(4);
            }
            else
            {
                transform.Find("ErrorInfo").gameObject.SetActive(true);
                GetComponent<Animator>().Play("ErrorMessage");
            }
        }
    }
}
