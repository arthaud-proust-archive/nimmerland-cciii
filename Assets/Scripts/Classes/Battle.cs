using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;
using HeroClasses;
using EnemyClasses;

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
        
        public int Tour;

        public Scene Scene;

        public Turn Turn;

        public List<Hero> Heroes = new List<Hero>();
        public List<Enemy> Enemies = new List<Enemy>();
        
        private List<Entity> entities = new List<Entity>();

        // définit à vide, on les remplis selon les niveaux (battle1, battle2, ...)
        private string background;
        private string music;
        private List<string> dialogs;

        public Battle()
        {
            CreateScene();
            FillHeroes();
            FillEnemies();
            FillEntities();
            OrderBySpeed();
        }

        public void CreateScene()
        {
            Scene = new Scene(background, music, dialogs);
        }


        public void FillHeroes()
        {
            Heroes.Add(new Hero1());
            Heroes.Add(new Hero2());
            Heroes.Add(new Hero3());
        }


        public virtual void FillEnemies()
        {
            // on remplit ici en fonction du niveau (Battle1, Battle2, ...)
        }


        // Créé un tableau contenant toutes les entités
        public virtual void FillEntities()
        {
            entities.Clear();
            foreach (Hero hero in Heroes)
            {
                entities.Add(hero);
            }

            foreach (Enemy enemy in Enemies)
            {
                entities.Add(enemy);
            }
        }


        public void OrderBySpeed()
        {
            Debug.Log(entities);
            Debug.Log("Sorting...");
            GFG gg = new GFG();
            entities.Sort(gg);
            entities.Reverse();
            Debug.Log(entities);
        }

        public void DoTour ()
        {
            Tour++;


        }

        public Turn GetTurn()
        {
            return Turn;
        }

        public Scene GetScene()
        {
            return Scene;
        }
    }

}