using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace Classes
{
    public class Enemy : Entity
    {
        public Enemy() :base()
        {
            EntityType = EntityTypes.Enemy;
        }


    }
}