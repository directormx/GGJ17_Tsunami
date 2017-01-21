using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
	[SerializeField]
	protected GameController gameController;

	[SerializeField]
	private float speed;



	private float velocity;

	public bool secondJump;



	virtual public void Start()
	{
		velocity = 4f;
	}

	virtual public void Move()
	{
		transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
	}


	public float getVelocity()
	{
		return velocity;
	}

}
