using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle1 : Battle
    {
        public string background = "level-1";

        public void FillEnemies()
        {
            Enemies.Add(new Enemy1());
        }
    }
}