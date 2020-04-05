using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPick : MonoBehaviour
{
    public GameObject Screen;
    public PlayerMovement player;
    public string KeyType;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (KeyType == "KeyToPick")
            {
                Screen.transform.Find("Key").gameObject.SetActive(true);
                Screen.transform.Find("Key").transform.Find("KeyToPick").gameObject.SetActive(true);
                Screen.transform.Find("Key").transform.Find("KeyToGive").gameObject.SetActive(false);
            } else
            {
                Screen.transform.Find("Key").gameObject.SetActive(true);
                Screen.transform.Find("Key").transform.Find("KeyToPick").gameObject.SetActive(false);
                Screen.transform.Find("Key").transform.Find("KeyToGive").gameObject.SetActive(true);
            }

            player.hasKey = true;
            Destroy(gameObject);
        }
    }
}
