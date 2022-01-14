using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle1 : Battle
    {
        public Battle1() :base() {}

        public override void FillScene()
        {
            Background = "level-1";
            Music = "music-1";
            Dialogs = new List<Dialog>{
                new Dialog(Heroes[0], "Test 1/3"),
                new Dialog(Heroes[1], "Test 2/3"),
                new Dialog(Heroes[0], "Test 3/3")
            };
        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy1());
        }
    }
}