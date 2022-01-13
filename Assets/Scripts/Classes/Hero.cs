using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace Classes
{
    public class Hero : Entity
    {
        public int actualDefense;


        public bool IsTypeOfEnemy()
        {
            return false;
        }
        public bool IsTypeOfHero()
        {
            return true;
        }
        public virtual void getAction()
        {

        }

        public virtual void FirstCapacity()
        {

        }

        public virtual void SecondCapacity()
        {

        }

        public virtual void ThirdCapacity()
        {

        }

    }
}
