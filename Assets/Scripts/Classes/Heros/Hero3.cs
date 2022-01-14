using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace HeroClasses
{
    public class Hero3 : Hero
    {
        public Hero3() : base()
        {
            BasePv = 85;
            BaseAttack = 25;
            BaseSpeed = 30;
            ActualPv = 85;
            BaseDefense = 0;
            ActualDefense = 0;

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