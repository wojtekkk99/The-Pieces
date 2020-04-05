using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour
{
    public int level;
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        if(level != 0 && level != 1)
            SaveLoadBoy.SaveGameLevel(this);
    }
    public void LoadLevel()
    {
        SaveLevel number = SaveLoadBoy.LoadGameLevel();
        if(number != null)
            GetComponentInParent<LevelChanger>().FadeToNextLevel(number.level);
    }
}
