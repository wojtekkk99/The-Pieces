using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    int sceneToLoad;
    public Animator animator;
    public void FadeToNextLevel(int scene)
    {
        sceneToLoad = scene;
        animator.SetTrigger("FadeOut");
    }

    public void FadeCompledte()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
