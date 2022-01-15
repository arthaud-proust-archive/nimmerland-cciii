using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace EnemyClasses
{
    public class Enemy3 : Enemy
    {
        public Enemy3(Battle battle) : base(battle)
        {
            BasePv = 300;
            BaseAttack = 40;
            BaseSpeed = 27;
            BaseDefense = 0;

            Name = "Chevalier Noir";
            DialogNameColor = Color.black;
        }
    }
}