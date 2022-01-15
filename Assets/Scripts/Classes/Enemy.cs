using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace Classes
{
    public class Enemy : Entity
    {
        public Enemy(Battle battle) :base(battle)
        {
            EntityType = EntityTypes.Enemy;
        }
    }
}
