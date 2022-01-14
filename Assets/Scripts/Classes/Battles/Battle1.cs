using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using EnemyClasses;

namespace BattleClasses
{
    public class Battle1 : Battle
    {
        public Battle1() :base()
        {
            Debug.Log("Battle1 constructor called");
            Background = "level-1";
            Music = "music-1";
            Dialogs = new List<string>{
                "Test 1/3",
                "Test 2/3",
                "Test 3/3"
            };
            CreateScene();
        }
        public override void FillEnemies()
        {
            Enemies.Add(new Enemy1());
        }
    }
}