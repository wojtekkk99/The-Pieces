using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScore : MonoBehaviour
{
    public int health;
    public int score;

    void Update()
    {
        health = GetComponent<Hearts>().health;
        score = transform.Find("CellingCheck").GetComponent<PlayerCollect>().score;
    }

    public void SavePlayerBoy()
    {
        SaveLoadBoy.SaveBoy(this, GetComponent<PlayerMovement>());
    }

    public void LoadPlayerBoy()
    {
        PlayerDataBoy data =  SaveLoadBoy.LoadBoy(GetComponent<PlayerMovement>());

        if (data != null)
        {
            health = data.health;
            score = data.score;
        }
        else
        {
            health = 3;
            score = 0;
        }
    }
}
