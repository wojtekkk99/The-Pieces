using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public LevelChanger levelChanger;
    public GameObject Screen;
    public GameObject Player;
    public int nexLevel;
    void Start()
    {
        GetComponent<MovingPlaform>().enabled = false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Player.GetComponent<PlayerMovement>().hasKey == true)
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
