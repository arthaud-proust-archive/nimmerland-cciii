using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classes
{
    enum EntityTypes { Enemy, Hero}

    public class Entity : MonoBehaviour, IComparable
    {
        public int BasePv;
        public int BaseAttack;
        public int BaseSpeed;
        
        public int ActualPv;
        public int ActualAttack;
        public int ActualSpeed;
        
        public Guid Guid;
        // public EntityTypes EntityType;

        public Entity()
        {
            Guid = Guid.NewGuid();
        }

        // Comparateur de vitesse
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Entity otherEntity= obj as Entity;
            if (otherEntity != null)
                return this.ActualSpeed.CompareTo(otherEntity.ActualSpeed);
            else
                throw new ArgumentException("Object is not an Entity");
            throw new NotImplementedException();
        }

        // Tests
        public bool IsDead()
        {
            return ActualPv < 0;
        }
        public bool IsAlive()
        {
            return ActualPv > 0;
        }
        public bool IsTypeOfEnemy()
        {
            return true;
            // return EntityType == "enemy";
        }
        public bool IsTypeOfHero()
        {
            return true;
            // return EntityType == "hero";
        }



        // Speed part
        public int GetSpeed()
        {
            return ActualSpeed;
        }

        
                
        // Pv part
        public int GetPv()
        {
            return ActualSpeed;
        }

        public void GainPv(int pvToGain)
        {
            ActualPv += pvToGain;
        }

        public void LosePv(int pvToLoose)
        {
            ActualPv -= pvToLoose;
        }



        // Attack part
        public void Attack(Entity entityToAttack)
        {
            entityToAttack.LosePv(ActualAttack);
        }

        public int GetAttack()
        {
            return ActualAttack;
        }

        public void GainAttack(int attackToGain)
        {
            ActualAttack += attackToGain;
        }

        public void LooseAttack(int attackToLoose)
        {
            ActualAttack += attackToLoose;
        }

    }
}