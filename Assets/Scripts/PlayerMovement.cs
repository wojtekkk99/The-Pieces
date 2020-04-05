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
	public bool IsFreeze = false;
	public GameObject gameOver;
	public bool IsPaused = false;
	public GameObject pauseScreen;
	private AudioSource walk_sound;

	public bool hasPickKey = false;
	public bool hasGiveKey = false;

	public bool isDead = false;
	void Start()
	{
		rgd = GetComponent<Rigidbody2D>();
		pauseScreen.gameObject.SetActive(false);
		gameOver.SetActive(false);
		walk_sound = GetComponent<AudioSource>();
		if (gender == "XX")
		{
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}

		GetComponent<HealthScore>().LoadPlayerBoy();
		GetComponent<Hearts>().health = GetComponent<HealthScore>().health;
		transform.Find("CellingCheck").gameObject.GetComponent<PlayerCollect>().score = GetComponent<HealthScore>().score;
		transform.Find("CellingCheck").gameObject.GetComponent<PlayerCollect>().uploadGui();
	}

	// Update is called once per frame

	void Update()
	{
		
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		Boy_animation.SetFloat("is_stand", Mathf.Abs(horizontalMove));

		if (Mathf.Abs(horizontalMove) != 0 && !walk_sound.isPlaying)
        {
			walk_sound.Play();
		}

		if (Input.GetKeyDown("w") && isGrounded)
		{
			jump = true;
		}

		if (isGrounded)
        {
			Boy_animation.SetBool("is_jump", false);
		}
        else
        {
			Boy_animation.SetBool("is_jump", true);
		}

		if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == false && !isDead)
		{
			GetComponent<Animator>().enabled = false;
			pauseScreen.SetActive(true);
			pauseScreen.GetComponent<Animator>().Play("ShowPause");
			rgd.constraints = RigidbodyConstraints2D.FreezePosition;
			IsFreeze = true;
		}
		if(Input.GetKey(KeyCode.Escape) && IsPaused == true && !isDead)
		{
			IsPaused = false;
			GetComponent<Animator>().enabled = true;
			pauseScreen.GetComponent<ButtonsActions>().resumePressed();
		}
	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}