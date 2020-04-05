using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveLevel
{
    public int level;

    public SaveLevel(LevelNumber data)
    {
        level = data.level;
    }
}

