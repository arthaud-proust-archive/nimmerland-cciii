using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classes
{

    public class Entity : MonoBehaviour
    {
        // Start is called before the first frame update

        public int basePv;
        public int baseAttack;
        public int baseSpeed;
        public int actualPv;


        public virtual void Attack()
        {

        }

        public virtual void GainLife()
        {

        }

        public virtual void LoseLife()
        {

        }

        public virtual void GainAttack()
        {

        }
    }

}



