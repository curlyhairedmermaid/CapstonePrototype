using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
