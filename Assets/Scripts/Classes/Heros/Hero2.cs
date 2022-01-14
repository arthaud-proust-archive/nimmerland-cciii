using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace HeroClasses
{
    public class Hero2 : Hero
    {
        public Hero2() : base()
        {
            BasePv = 100;
            BaseAttack = 15;
            BaseSpeed = 35;
            ActualPv = 100;
            BaseDefense = 0;
            ActualDefense = 0;

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