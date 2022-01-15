using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace HeroClasses
{
    public class Hero2 : Hero
    {
        public Hero2(Battle battle) : base(battle)
        {
            BasePv = 85;
            BaseAttack = 25;
            BaseSpeed = 30;
            BaseDefense = 0;

            Name = "Kirchlich Runden";
            DialogNameColor = Color.blue;
        }

        public override void getAction()
        {

        }

        public override void FirstCapacity()
        {
        }

        public override void SecondCapacity()
        {

        }

        public override void ThirdCapacity()
        {
        }

    }
}