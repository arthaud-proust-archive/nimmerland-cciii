using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace EnemyClasses
{
    public class Enemy2 : Enemy
    {
        public Enemy2(Battle battle) : base(battle)
        {
            Visible = false;
            BasePv = 150;
            BaseAttack = 15;
            BaseSpeed = 20;
            BaseDefense = 0;

            Name = "Prêtresse";
            DialogNameColor = Color.black;
        }
    }
}