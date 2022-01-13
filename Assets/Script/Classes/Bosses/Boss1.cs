using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace BossClasses
{
    public class Boss1 : Boss
    {
        public int basePv = 200;
        public int baseAttack = 30;
        public int baseSpeed = 40;
        public int actualPv = 200;

        public virtual void Capacity()
        {

        }
    }
}