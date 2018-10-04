using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement: MonoBehaviour {

    // Use this for initialization
    private EnemyState enemyState;
    void Start()
    {
        SwitchEnemyState(new EnemyIdle());

    }

    /// <summary>
    /// updates every frame. on mouse down, shoots a ray out to see where the mouse is pointed and moves the character there
    /// </summary>
        public void Update()
        {
        if (enemyState != null)
        {
            EnemyState newState = enemyState.Update();
            SwitchEnemyState(newState);
        }
    }
    private void SwitchEnemyState(EnemyState newState)
    {
        if (newState != null)
        {
            //switch to new state
            if (enemyState != null) enemyState.onEnd();
            enemyState = newState;
            enemyState.onBegin(this);
        }
    }

}
