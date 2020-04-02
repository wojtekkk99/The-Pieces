using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollect : MonoBehaviour
{
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = (int)System.Char.GetNumericValue(text.text[2]);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Collected")
        {
            Destroy(other.gameObject);
            score += 1;
            text.text = "X " + score;
        }
    }
}
