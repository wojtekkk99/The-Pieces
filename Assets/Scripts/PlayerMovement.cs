using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2D controller;
	public float distToGround;
	public float runSpeed = 40f;
	GameObject ground;

	float horizontalMove = 0f;
	bool jump = false;
	bool isGrounded = true;
	void Start()
	{
	
	}

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetKeyDown("up") && isGrounded)
		{
			jump = true;
		}

	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}

	}
	void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.tag == "Ground")
		{
			isGrounded = false;
		}

	}
}