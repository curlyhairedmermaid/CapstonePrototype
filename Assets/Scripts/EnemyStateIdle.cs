using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Extends from Enemystate. For when the Enemy is Idle
/// </summary>
public class EnemyStateIdle : EnemyState
{

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
	int MaxDist = 10;
	/// <summary>
	/// The minimum dist the enemy will follow
	/// </summary>
	int MinDist = 5;
	/// <summary>
	/// The attack distance for the enemy
	/// </summary>
	void Start () {

	}

	// Update is called once per frame
	override public EnemyState Update() {
		//Put behavior here!'
		//put transitions here!
		transform.LookAt(Player);

		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			return new EnemyStatePursue();

		}
		// if (condition is true) trurn new <EnemyStateSomething>();
		return null;
	}

}
