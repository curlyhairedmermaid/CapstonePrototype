using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateIdle : EnemyState
{

    // Use this for initialization
    private EnemyMovement enemyMovement;
	public Transform Player;
	int MoveSpeed = 4;
	int MaxDist = 10;
	int MinDist = 5;
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
