using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace EnemyClasses
{
    public class EnemyUnknown : Enemy
    {
        public EnemyUnknown(Battle battle) : base(battle)
        {
            Name = "???";
            DialogNameColor = Color.black;
        }
    }
}