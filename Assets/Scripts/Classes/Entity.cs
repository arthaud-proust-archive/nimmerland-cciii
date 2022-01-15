using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classes
{
    public enum EntityTypes { Enemy, Hero}

    public class Entity : IComparable
    {
        private readonly System.Random rnd = new System.Random();

        private int _basePv = 0;
        private int _baseAttack = 0;
        private int _baseSpeed = 0;
        private int _baseDefense = 0;

        private int _actualPv = 0;
        private int _actualAttack = 0;
        private int _actualSpeed = 0;
        private int _actualDefense = 0;

        private Color _dialogNameColor = Color.white;

        private string _name = "not_defined";

        public int BasePv{
            get => _basePv;
            set { _basePv = value;  _actualPv = value; }
        }
        public int BaseAttack
        {
            get => _baseAttack;
            set { _baseAttack = value; _actualAttack = value; }
        }

        public int BaseSpeed
        {
            get => _baseSpeed;
            set { _baseSpeed = value; _actualSpeed = value; }
        }
        public int BaseDefense
        {
            get => _baseDefense;
            set { _baseDefense = value; _actualDefense = value; }
        }




        public int ActualPv
        {
            get => _actualPv;
            set => _actualPv = value;
        }
        public int ActualAttack
        {
            get => _actualAttack;
            set => _actualAttack = value;
        }

        public int ActualSpeed
        {
            get => _actualSpeed;
            set => _actualSpeed = value;
        }
        public int ActualDefense
        {
            get => _actualDefense;
            set => _actualDefense = value;
        }



        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public Color DialogNameColor
        {
            get => _dialogNameColor;
            set => _dialogNameColor = value;
        }


        public Battle Battle { get; set; }
        public bool? Visible { get; set; }

        public Guid Guid;
        public EntityTypes EntityType { get; set; }

        public Entity(Battle battle)
        {
            Battle = battle;
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
            return EntityTypes.Enemy.Equals(EntityType);
        }
        public bool IsTypeOfHero()
        {
            return EntityTypes.Hero.Equals(EntityType);
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
        public string GetLifeString()
        {
            return ActualPv + " / " + BasePv;
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
        public void AttackRandom(List<Entity> entities)
        {
            int iToAttack = rnd.Next(entities.Count);
            Attack(entities[iToAttack]);
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