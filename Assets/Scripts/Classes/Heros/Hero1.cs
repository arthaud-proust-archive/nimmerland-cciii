using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace HeroClasses
{
    public class Hero1 : Hero
    {
        public int basePv = 115;
        public int baseAttack = 20;
        public int baseSpeed = 25;
        public int actualPv = 115;
        public int actualDefense = 0;
        public bool Platz1 = false;

        public virtual void getAction()
        {

        }

        public virtual void FirstCapacity()
        {
            Platz1 = true;
        }

        public virtual void SecondCapacity()
        {

        }

        public virtual void ThirdCapacity()
        {
            actualDefense = 20;
        }

    }
}
