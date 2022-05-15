﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	PlayerMovement player;
	public void Start()
    {
		player = transform.parent.gameObject.GetComponent<PlayerMovement>();
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Moving Platform")
		{
			player.isGrounded = true;
		}
		if (other.gameObject.tag == "Moving Platform")
		{
			Transform m_platform = other.gameObject.transform;
			transform.parent.gameObject.transform.SetParent(m_platform);
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Moving Platform")
		{
			player.isGrounded = false;
		}
		if (other.gameObject.tag == "Moving Platform")
		{
			transform.parent.gameObject.transform.SetParent(null);
		}

	}
}
