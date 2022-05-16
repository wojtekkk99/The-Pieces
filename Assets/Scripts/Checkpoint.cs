using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerCollect other;
    public Hearts hearts;
    public Sprite sprite;

    public void SetCheckpoint()
    {
        if(other.score != 0)
        {
            other.score -= 1;
            other.uploadGui();
            GameObject checkpoint = new GameObject();
            checkpoint.transform.position = transform.position;
            hearts.lastCheckpoint = transform.position;
            checkpoint.AddComponent<SpriteRenderer>().sprite = sprite;
            checkpoint.GetComponent<SpriteRenderer>().maskInteraction = SpriteMaskInteraction.VisibleOutsideMask;
            checkpoint.transform.localScale = new Vector3(0.15f, 0.15f, 0.9f);
        }
    }
}
