using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public void restartPressed()
    {
        player.GetComponent<HealthScore>().health = 3;
        player.GetComponent<HealthScore>().SavePlayerBoy();
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
    public void maxHealth()
    {
        player.GetComponent<Hearts>().health = 3;
    }
}
