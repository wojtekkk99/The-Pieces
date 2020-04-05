using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerDataBoy
{
    public int health;
    public int score;

    public PlayerDataBoy(HealthScore dates)
    {
        health = dates.health;
        score = dates.score;
    }
}
