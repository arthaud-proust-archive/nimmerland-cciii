using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace HeroClasses
{
    public class Hero1 : Hero
    {
        public Hero1(Battle battle) :base(battle) {
            BasePv = 100;
            BaseAttack = 15;
            BaseSpeed = 35;
            BaseDefense = 0;

            Name = "Magy Dreieck";
            DialogNameColor = Color.green;
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
