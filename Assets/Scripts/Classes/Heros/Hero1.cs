using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace HeroClasses
{
    public class Hero1 : Hero
    {
        public Hero1() :base() {
            BasePv = 115;
            BaseAttack = 20;
            BaseSpeed = 25;
            ActualPv = 115;
            BaseDefense = 0;
            ActualDefense = 0;

            Name = "Ritter von Platz";
            DialogNameColor = Color.red;
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
            ActualDefense = 20;
        }

    }
}
