using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(This class is responsible for activating the following state of enemy, thus changing state)

namespace BattleTank
{
    public class EnemyFollow : EnemyState
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            enemyView.activeState = EnemyStateEnum.Follow;
        }
        public void Update()
        {
            enemyView.enemyController.Follow();
        }
        public override void OnStateExit()
        {
            base.OnStateExit();
        }
    }

}
