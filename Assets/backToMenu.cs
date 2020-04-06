using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToMenu : MonoBehaviour
{
    public LevelChanger levelChanger;

    void Start()
    {
        GetComponent<Animator>().Play("Outro1");
    }
    public void backMenu()
    {
        levelChanger.FadeToNextLevel(0);
    }
}
