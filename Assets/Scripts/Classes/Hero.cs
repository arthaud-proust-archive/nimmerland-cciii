using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace Classes
{
    public class Hero : Entity
    {
        public Hero(Battle battle) : base(battle) {
            EntityType = EntityTypes.Hero;
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
