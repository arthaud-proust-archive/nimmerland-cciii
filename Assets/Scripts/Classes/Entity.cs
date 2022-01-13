using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classes
{

    public class Entity : MonoBehaviour, IComparable
    {
        public int basePv;
        public int baseAttack;
        public int baseSpeed;
        
        public int actualPv;
        public int actualAttack;
        public int actualSpeed;
        
        public string type;

        // Comparateur de vitesse
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Entity otherEntity= obj as Entity;
            if (otherEntity != null)
                return this.actualSpeed.CompareTo(otherEntity.actualSpeed);
            else
                throw new ArgumentException("Object is not an Entity");
            throw new NotImplementedException();
        }

        // Tests
        public bool IsDead()
        {
            return actualPv < 0;
        }
        public bool IsAlive()
        {
            return actualPv > 0;
        }



        // Speed part
        public int GetSpeed()
        {
            return actualSpeed;
        }

        
                
        // Pv part
        public int GetPv()
        {
            return actualSpeed;
        }

        public void GainPv(int pvToGain)
        {
            actualPv += pvToGain;
        }

        public void LosePv(int pvToLoose)
        {
            actualPv -= pvToLoose;
        }



        // Attack part
        public void Attack(Entity entityToAttack)
        {
            entityToAttack.LosePv(baseAttack);
        }

        public int GetAttack()
        {
            return actualAttack;
        }

        public void GainAttack(int attackToGain)
        {
            actualAttack += attackToGain;
        }

        public void LooseAttack(int attackToLoose)
        {
            actualAttack += attackToLoose;
        }

    }
}