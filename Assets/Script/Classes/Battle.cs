using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace Battle
{

    public class Battle : MonoBehaviour
    {
        public int iTour;
        public Boss boss;

        public Hero [] heroes;
        public Enemy [] enemies;
        public Boss boss;

        public virtual void OrderBySpeed()
        {

        }

        public virtual void DoTour ()
        {

        }
    }

}