using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public string gender = "XY";
	public CharacterController2D controller;
	public float distToGround;
	public float runSpeed = 40f;
	public Animator Boy_animation;

	float horizontalMove = 0f;
	bool jump = false;
	public bool isGrounded = true;
	Rigidbody2D rgd;
	public GameObject animator;
	public bool IsFreeze = false;
	public GameObject gameOver;
	public bool IsPaused = false;
	public GameObject pauseScreen;
	void Start()
	{
		rgd = GetComponent<Rigidbody2D>();
		animator.gameObject.SetActive(false);
		gameOver.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		Boy_animation.SetFloat("is_stand", Mathf.Abs(horizontalMove));

		if (Input.GetKeyDown("w") && isGrounded)
		{
			jump = true;
		}

		if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == false)
		{
			animator.SetActive(true);
			animator.GetComponent<Animator>().Play("ShowPause");
			rgd.constraints = RigidbodyConstraints2D.FreezePosition;
			IsFreeze = true;
		}
		if(Input.GetKey(KeyCode.Escape) && IsPaused == true)
		{
			IsPaused = false;
			pauseScreen.GetComponent<ButtonsActions>().resumePressed();
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
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Moving Platform")
		{
			isGrounded = true;
		}
		if (other.gameObject.tag == "Moving Platform")
		{
			Transform m_platform = other.gameObject.transform;
			transform.SetParent(m_platform);
		}

	}
	void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Moving Platform")
		{
			isGrounded = false;
		}
		if(other.gameObject.tag == "Moving Platform")
		{
			transform.SetParent(null);
		}

	}
}