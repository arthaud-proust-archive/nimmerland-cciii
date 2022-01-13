using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle1 : Battle
    {
        private string background = "level-1";
        private string sound = "sound-1",
        private List<string> dialogs = new List<string>
        {
            "Test 1/3",
            "Test 2/3",
            "Test 3/3"
        }

        public void FillEnemies()
        {
            Enemies.Add(new Enemy1());
        }
    }
}