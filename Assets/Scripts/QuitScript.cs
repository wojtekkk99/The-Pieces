using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animationQuit;
    public void FadeToQuit()
    {
        animationQuit.Play("Fade_out_quit");
    }

    public void newGame()
    {
        SaveLoadBoy.Delete();
    }

}
