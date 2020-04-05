using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerMovement>().isGrounded == true)
            {
                gameObject.transform.GetComponentInParent<MovingPlaform>().moveUp = true;
            }
        }
    }
}
