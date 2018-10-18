using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Abstact over all class for the enemy's state
/// </summary>
abstract public class EnemyState {
	/// <summary>
	/// A Reference to the Enemy Movement Class
	/// </summary>
    private EnemyMovement movement;
	/// <summary>
	/// Creation of an Abstract update method
	/// </summary>
    abstract public EnemyState Update();
	/// <summary>
	/// This code runs when each method begins
	/// </summary>
	/// <param name="movement">Movement. reference to the movement class</param>
    virtual public void onBegin(EnemyMovement movement)
    {
        this.movement = movement;
    }
/// <summary>
/// Runs when each class ends
/// </summary>
    virtual public void onEnd()
    {

    }
}
