using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace EnemyClasses {
    public class Enemy1 : Enemy
    { 
        public Enemy1() :base()
        {
            BasePv = 200;
            BaseAttack = 30;
            BaseSpeed = 40;
            BaseDefense = 0;

            Name = "Roi des Bandits";
            DialogNameColor = Color.black;
        }
    }
}