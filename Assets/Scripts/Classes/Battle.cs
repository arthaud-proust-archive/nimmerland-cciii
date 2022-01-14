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
        public string Background;
        public string Music;
        public List<Dialog> Dialogs;

        public Battle()
        {
            

            FillHeroes();
            FillEnemies();
            FillEntities();

            FillScene();
            CreateScene();

            OrderBySpeed();
        }

        public void CreateScene()
        {
            Scene = new Scene(Background, Music, Dialogs);
        }


        public void FillHeroes()
        {
            // corrigé ça marche les hero sont bien instanciés
            Heroes.Add(new Hero1());
            Heroes.Add(new Hero2());
            Heroes.Add(new Hero3());
        }

        public virtual void FillScene()
        {
            // on remplit ici en fonction du niveau (Battle1, Battle2, ...)
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