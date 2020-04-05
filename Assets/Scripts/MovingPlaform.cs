using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlaform : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 begin;
    public bool moveUp;
    public Transform target;
    public float moveSpeed = 3f;
    void Start()
    {
        begin = transform.position;
        moveUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == target.position)
        {
            moveUp = false;
        }
        else if(transform.position == begin)
        {
            moveUp = true;
        }

        if(!moveUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, begin, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }
}
