using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollect : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int score;
    private AudioSource elem_sound;
    // Start is called before the first frame update
    void Start()
    {
        score = (int)System.Char.GetNumericValue(text.text[2]);
        elem_sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Collected")
        {
            Destroy(other.gameObject);
            score += 1;
            text.text = "X " + score;
            elem_sound.Play();
        }
    }

    public void uploadGui()
    {
        text.text = "X " + score;
    }
}
