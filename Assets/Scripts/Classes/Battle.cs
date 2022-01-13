using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using HeroClasses;

class GFG : IComparer<Entity>
{
    public int Compare(Entity x, Entity y)
    {

        if (x == null || y == null)
        {
            return 0;
        }

        // "CompareTo()" method
        return x.CompareTo(y);
    }
}

namespace Classes
{

    public class Battle : MonoBehaviour
    {
        public int tour;
        
        private List<Entity> entities = new List<Entity>();

        private List<Hero> heroes = new List<Hero>();
        private List<Enemy> enemies = new List<Enemy>();
        public Boss boss;

        public Battle()
        {
            FillHeroes();
        }

        public void FillHeroes()
        {
            heroes.Add(new Hero1());
            heroes.Add(new Hero2());
            heroes.Add(new Hero3());
        }

        public virtual void FillEnemies()
        {
        }

        // Créé un tableau contenant toutes les entités
        public virtual void FillEntities()
        {
            entities.Clear();
            foreach (Hero hero in heroes)
            {
                entities.Add(hero);
            }

            foreach (Enemy enemy in enemies)
            {
                entities.Add(enemy);
            }

            if (boss) entities.Add(boss);
        }


        public void OrderBySpeed()
        {
            Debug.Log(entities);
            Debug.Log("Sorting...");
            GFG gg = new GFG();
            entities.Sort(gg);
            Debug.Log(entities);
        }

        public void DoTour ()
        {

        }

        public Turn GetTurn()
        {
            return new Turn();
        }
    }

}