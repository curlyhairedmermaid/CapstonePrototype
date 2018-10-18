using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement: MonoBehaviour {

    // Use this for initialization
    private EnemyState enemyState;
	/// <summary>
	/// the player's location
	/// </summary>
	public Transform Player;
	/// <summary>
	/// The move speed for the enemy
	/// </summary>
	int MoveSpeed = 4;
	/// <summary>
	/// The max dist the enemy will follow
	/// </summary>
	int MaxDist = 6;
	/// <summary>
	/// The minimum dist the enemy will follow
	/// </summary>
	int MinDist = 3;
	/// <summary>
	/// The attack distance for the enemy
	/// </summary>
	int attackDistance = 1;
	bool isAttacking = false;
	bool isPursuing = false;
	bool isIdle = false;
	bool isDead = false;

    void Start()
    {
		isIdle = true;

    }

    /// <summary>
    /// updates every frame. on mouse down, shoots a ray out to see where the mouse is pointed and moves the character there
    /// </summary>
        public void Update()
        {
		if (isDead) {
			Dead ();
		} else if (isAttacking) {
			Attacking ();
		} else if (isPursuing) {
			Pursuing ();
		} else {
			Idle ();
		}
				
    }
	/// <summary>
	/// Switchs the state of the enemy.
	/// </summary>
	/// <param name="newState">New state to be switched to</param>
    private void Attacking()
    {
		Debug.Log("I Am Attacking");
    }
	private void Idle()
	{
		transform.LookAt(Player);

		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			isPursuing = true;

		}
	}
	private void Pursuing()
	{
		
		transform.position += transform.forward * MoveSpeed * Time.deltaTime;

		if (Vector3.Distance (transform.position, Player.position) <= MaxDist) {
			isIdle = true;

		} else if (Vector3.Distance (transform.position, Player.position) <= attackDistance) {
			isAttacking = true;
		}
	}
	private void Dead()
	{
		print ("I am dead");
	}

}
