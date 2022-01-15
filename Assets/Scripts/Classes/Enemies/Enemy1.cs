using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace EnemyClasses 
{
    public class Enemy1 : Enemy
    { 
        public Enemy1(Battle battle) : base(battle)
        {
            Visible = false;
            BasePv = 200;
            BaseAttack = 30;
            // Le jeu est trop facile?
            //BaseAttack = 3000000;
            // oui oui le game over fonctionne rho
            BaseSpeed = 40;
            BaseDefense = 0;

            Name = "Roi des Bandits";
            DialogNameColor = Color.black;
        }
    }
}