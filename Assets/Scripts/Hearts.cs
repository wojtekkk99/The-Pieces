using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class Hearts : MonoBehaviour
{
    public int health;

    public Image[] hearts;

    public Sprite OneHeart;

        // Update is called once per frame
        void Update()
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
