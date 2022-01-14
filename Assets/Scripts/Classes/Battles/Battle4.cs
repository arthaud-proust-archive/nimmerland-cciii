using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle4 : Battle
    {
        private string background = "level-1";
        private string music = "music-1";
        private List<string> dialogs = new List<string>
        {
            "Test 1/3",
            "Test 2/3",
            "Test 3/3"
        };

        public Battle4() : base()
        {

        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy1());
        }
    }
}