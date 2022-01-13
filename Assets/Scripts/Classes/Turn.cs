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
        private Type entityToPlayType;
        public Battle Battle;
        public int TurnNumber;

        public List<Entity> Allies = new List<Entity>();
        public List<Entity> Enemies = new List<Entity>();

        public Turn(Entity entity, Battle battle)
        {
            EntityToPlay = entity;
            entityToPlayType = EntityToPlay.GetType();
            Battle = battle;
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
        public void ComputeEnemies()
        {
            // Si 
            if (EntityToPlay.IsTypeOfEnemy())
            {

            }
        }

        public void ComputeAllies()
        {

        }
    }
}
