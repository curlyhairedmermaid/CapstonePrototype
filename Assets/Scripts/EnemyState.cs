using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Abstact over all class for the enemy's state
/// </summary>
abstract public class EnemyState {
    private EnemyMovement movement;
    abstract public EnemyState Update();
    virtual public void onBegin(EnemyMovement movement)
    {
        this.movement = movement;
    }
    virtual public void onEnd()
    {

    }
}
