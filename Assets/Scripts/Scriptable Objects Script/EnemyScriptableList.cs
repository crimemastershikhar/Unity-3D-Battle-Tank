using System.Collections;
using System.Collections.Generic;
using EnemyServices;
using UnityEngine;

namespace EnemySO
{
    [CreateAssetMenu(fileName = "EnemyScriptableObjectList", menuName = "ScriptableObject/Enemy/CreateEnemyList")]
    public class EnemyScriptableList : ScriptableObject
    {
        public EnemyScriptableObject[] enemies;

        public EnemyView enemyView { get; internal set; }
    }
}