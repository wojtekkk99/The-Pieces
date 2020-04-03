using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void restartPressed()
    {
        GetComponent<Animator>().Play("GameOverReset");  
    }
    public void resetLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void menuPressed()
    {
        GetComponent<Animator>().Play("GameOverMenu");
    }
    public void menuLoad()
    {
        transform.Find("Panel").gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
