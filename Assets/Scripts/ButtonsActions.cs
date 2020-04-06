    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsActions : MonoBehaviour
{
    public Animator animator;
    public PlayerMovement player;
    // Start is called before the first frame update
    public LevelChanger change;
    public void resumePressed()
    {   
        animator.SetTrigger("ResumeGame");
    }

    public void afterResume()
    {
        player.IsPaused = false;
        player.IsFreeze = false;
        player.GetComponent<Animator>().enabled = true;
        animator.gameObject.SetActive(false);
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public void mainMenuPressed()
    {
        animator.SetTrigger("ResumeGame");
        change.GetComponent<LevelChanger>().FadeToNextLevel(0);
    }

    public void restartPressed()
    {      
        animator.SetTrigger("ResumeGame");
        change.GetComponent<LevelChanger>().FadeToNextLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public void setPause()
    {
        player.IsPaused = true;
    }
}
