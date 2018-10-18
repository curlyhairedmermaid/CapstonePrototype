using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Extends from Enemy State, is the attacking portion of the enemy's logic
/// </summary>
public class EnemyStateAttack : EnemyState
{

/// <summary>
/// update is where the attacking is currently being done
/// </summary>
    override public EnemyState Update()
    {
        //Put behavior here!'
        //put transitions here!
		Debug.Log("I Am Attacking");
        // if (condition is true) trurn new <EnemyStateSomething>();
        return null;
    }

}
