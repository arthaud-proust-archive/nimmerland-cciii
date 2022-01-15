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
    public enum BattleStatus { Processing, Won, Lost }
    public class Battle
    {
        

        // 1 pass  = 1 tour pour chaque entité
        public int PassI = 0;
        public int TurnI = 0;

        public BattleStatus BattleStatus= BattleStatus.Processing;


        public Scene Scene;

        public List<Turn> Turns = new List<Turn>();

        public List<Entity> Heroes = new List<Entity>();
        public List<Entity> Enemies = new List<Entity>();
        
        private List<Entity> entities = new List<Entity>();

        // définit à vide, on les remplis selon les niveaux (battle1, battle2, ...)
        public string Background;
        public string Music;
        public List<Dialog> DialogsBefore;
        public List<Dialog> DialogsAfter;

        public Battle()
        {
            FillHeroes();
            FillEnemies();
            FillEntities();

            FillScene();
            CreateScene();

            OrderBySpeed();

        }

        public bool ShouldSkipDialog()
        {
            return false;
        }

        public bool IsEnded()
        {
            return (BattleStatus.Equals(BattleStatus.Lost) 
                || BattleStatus.Equals(BattleStatus.Won));
        }
        public bool IsLost()
        {
            return (BattleStatus.Equals(BattleStatus.Lost));
        }

        public bool IsWon()
        {
            return (BattleStatus.Equals(BattleStatus.Won));
        }

        public void CreateScene()
        { 
            Scene = new Scene(Background, Music, DialogsBefore, DialogsAfter);
        }


        public void FillHeroes()
        {
            // corrigé ça marche les hero sont bien instanciés
            Heroes.Add(new Hero1(this));
            Heroes.Add(new Hero2(this));
            Heroes.Add(new Hero3(this));
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
            Debug.Log("Sorting...");
            GFG gg = new GFG();
            entities.Sort(gg);
            entities.Reverse();
        }

        public void EndTurn()
        {
            GetTurn().DoAction();
            // tester fin battle
            UpdateBattleStatus();
        }
        public void BeginTurn()
        {
            TurnI++;
            if(TurnI == entities.Count)
            {
                TurnI = 0;
            }
            Turns.Add(new Turn(entities[TurnI], this, TurnI));
        }

        public void UpdateBattleStatus()
        {
            BattleStatus = BattleStatus.Processing;

            foreach (Hero hero in Heroes)
            {
                if(hero.IsDead())
                {
                    Debug.Log(hero.Name+": "+hero.GetLifeString());
                    BattleStatus = BattleStatus.Lost;
                    return;
                }
            }

            foreach (Enemy enemy in Enemies)
            {
                if (enemy.IsDead())
                {
                    BattleStatus = BattleStatus.Won;
                    return;
                }
            }
        }

        public Turn GetTurn()
        {
            return Turns[Turns.Count-1];
        }

        public Scene GetScene()
        {
            return Scene;
        }
    }

}