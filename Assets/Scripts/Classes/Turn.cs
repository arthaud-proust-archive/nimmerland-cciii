using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Classes;

namespace Classes
{
    public class Turn
    {
        public Entity EntityToPlay;
        public Battle Battle;
        public int TurnNumber;

        public string Action { get; set; }
        public string Target { get; set; }

        public List<Entity> Allies = new List<Entity>();
        public List<Entity> Enemies = new List<Entity>();

        public Turn(Entity entity, Battle battle, int turnNumber)
        {
            EntityToPlay = entity;
            Battle = battle;
            TurnNumber = turnNumber;

            ComputeAlliesAndEnemies();
        }


        public void DoAction()
        {
            if (Action == "Attack")
            {
                if(EntityToPlay.IsTypeOfHero())
                { 
                    EntityToPlay.Attack(Enemies[0]);
                } else
                {
                    EntityToPlay.AttackRandom(Enemies);
                }
            }
        }

        // Retourne toutes les entitées passées sauf cette qui doit jouer dans ce tour.
        private List<Entity> getEntitiesExceptEntityToPlay(List<Entity> listToAnalyse)
        {
            List<Entity> listToReturn = new List<Entity>();
            foreach(Entity entity in listToAnalyse)
            {
                if (!EntityToPlay.Guid.Equals(entity.Guid))
                {
                    listToReturn.Add(entity);
                }
            }
            return listToReturn;
        }

        public void ComputeAlliesAndEnemies()
        {
            // Si c'est un type ennemi, ses alliés sont les types ennemy et ses ennemis sont les type hero
            if (EntityToPlay.IsTypeOfEnemy())
            {
                Allies = getEntitiesExceptEntityToPlay(Battle.Enemies);
                Enemies = getEntitiesExceptEntityToPlay(Battle.Heroes);
            } 
            // et inversement
            else
            {
                Allies = getEntitiesExceptEntityToPlay(Battle.Heroes);
                Enemies = getEntitiesExceptEntityToPlay(Battle.Enemies);
            }
        }

    }
}
