using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToGame : MonoBehaviour
{
    public LevelChanger levelChanger;

    // Update is called once per frame
    public void goToGame()
    {
        levelChanger.FadeToNextLevel(2);
    }
}
