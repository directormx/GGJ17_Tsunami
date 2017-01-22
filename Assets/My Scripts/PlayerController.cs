using UnityEngine;
using UnityEngine.UI;

public class PlayerController : BaseCharacter
{
	[SerializeField]
	private float jumpForce;


	private AudioSource audioSource;

	public float volume;

	public AudioClip jumpSound;
	public AudioClip takeHitSound;

	bool grounded;

	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Use this for initialization
	override public void Start()
	{
		base.Start();
		Time.timeScale = 1;

	}

	// Update is called once per frame
	void Update()
	{
		HandleInput();

	}


	// FixedUpdate is called every fixed framerate frame
	void FixedUpdate()
	{
		Move();
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Ground")
		{
			grounded = true;
		}
		if (coll.gameObject.tag == "Civilians") {
			gameController.IncreaseCivilians ();
			Destroy (coll.gameObject);
		}
	
	}

	public void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Collectible") {
			gameController.IncreaseCollectible ();
			Destroy (coll.gameObject);
		}
		if (coll.gameObject.tag == "Civilians") {
			gameController.IncreaseCivilians ();
			Destroy (coll.gameObject);
		}
	}
		

	override public void Move()
	{
		// Player Movements
	}

	private void HandleInput()
	{


		//double jump
		if (Input.GetKeyDown(KeyCode.Space) && secondJump && !grounded)
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			secondJump = false;
			PlayJumpSound();
		}
		// Jump
		if (Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			secondJump = true;
			grounded = false;
			PlayJumpSound();
		}

		if (grounded)
			secondJump = false;
	}



	void PlayJumpSound()
	{
		audioSource.PlayOneShot(jumpSound, volume);
	}

	void PlayTakeHitSound()
	{
		audioSource.PlayOneShot(takeHitSound, volume);
	}
}
