using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatate : MonoBehaviour
{
    public float rotationSpeed = 7f;
    void Update()
    {
        transform.Rotate(0, 0, 6 * rotationSpeed * Time.deltaTime);
    }
}
