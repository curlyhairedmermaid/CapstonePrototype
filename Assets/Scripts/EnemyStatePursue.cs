using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Extends from EnemyState. For when the enemy is pursuing.
/// </summary>
public class EnemyStatePursue : EnemyState
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
	int attackDistance = 2;
/// <summary>
/// moves the enemy
/// </summary>
    override public EnemyState Update()
    {
        //Put behavior here!'
        //put transitions here!
		transform.position += transform.forward * MoveSpeed * Time.deltaTime;



		if (Vector3.Distance (transform.position, Player.position) <= MaxDist) {
			return new EnemyStateIdle ();

		} else if (Vector3.Distance (transform.position, Player.position) >= attackDistance) {
			return new EnemyStateAttack ();
		}
        // if (condition is true) trurn new <EnemyStateSomething>();
        return null;
    }

}
