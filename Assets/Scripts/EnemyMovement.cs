using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement: MonoBehaviour {

	/// <summary>
	/// the player's location
	/// </summary>
	public Transform Player;
	/// <summary>
	/// The move speed for the enemy
	/// </summary>
	float moveSpeed = 2.5f;
	/// <summary>
	/// The max dist the enemy will follow
	/// </summary>
	int maxDist = 6;
	/// <summary>
	/// The minimum dist the enemy will follow
	/// </summary>
	int minDist = 2;
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

    }

    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= maxDist)
        {
            transform.position += new Vector3(0, 0, 0);
        }else if (Vector3.Distance(transform.position, Player.position) <= maxDist && Vector3.Distance(transform.position, Player.position) <= minDist)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            print("attack");
            moveSpeed = 1f;
            ///attack

        }
        else if (Vector3.Distance(transform.position, Player.position) <= maxDist)
        {
            moveSpeed = 2.5f;
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

    }
}