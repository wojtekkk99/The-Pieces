using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerCollect other;
    public Hearts hearts;
    public Sprite sprite;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && other.score != 0)
        {
            other.score -= 1;
            other.uploadGui();
            GameObject checkpoint = new GameObject();
            checkpoint.transform.position = transform.position;
            hearts.lastCheckpoint = transform.position;
            checkpoint.transform.Rotate(-0.7f, 0f, 26f);
            checkpoint.AddComponent<SpriteRenderer>().sprite = sprite;
            checkpoint.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        }
    }
}
