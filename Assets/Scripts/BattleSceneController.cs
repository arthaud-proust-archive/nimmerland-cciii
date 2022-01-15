using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using Classes;
using UnityEngine.Experimental.U2D.Animation;

namespace Classes {
    public class BattleSceneController : MonoBehaviour
    {
        public BattleController BattleController { get; set; }

        public GameObject BattleGroup;
        public Button ActionToSelectFirst;
        public Button HeroSelectionToSelectFirst;

        public SpriteResolver BackgroundSpriteResolver;
        public SpriteResolver EnemySpriteResolver;
        public GameObject BackgroundSprite; 
        public GameObject EnemySprite;
        public GameObject HeroesPvList;
        public GameObject EnemiesPvList;

        private Battle Battle;

        public void SetBattle(Battle battle)
        {
            Battle = battle;
        }
        // Start is called before the first frame update
        void Start()
        {
        }

        public void SetBattleGroupVisible(bool visible)
        {
            BattleGroup.SetActive(visible);
        }

        public void ShowBattleGroup()
        {
            SetBattleGroupVisible(true);
            ActionToSelectFirst.Select();
        }

        public void UpdatePv()
        {
            UpdatePvOfList(Battle.Heroes, HeroesPvList);
            UpdatePvOfList(Battle.Enemies, EnemiesPvList);
        }

        public void UpdateVisibilityOfEnemySprite()
        {
            Debug.Log("Enemy visible");
            Debug.Log(Battle.Enemies[0]);
            Debug.Log(Battle.Enemies[0].Visible);
            EnemySprite.GetComponent<Renderer>().enabled = (bool)Battle.Enemies[0].Visible;
        }

        public void LoadBackgroundSprite()
        {
            Debug.Log(Battle.GetScene().Background);
            BackgroundSpriteResolver.SetCategoryAndLabel("Backgrounds", Battle.GetScene().Background);
            BackgroundSpriteResolver.ResolveSpriteToSpriteRenderer();
            // Debug.Log(BackgroundSprite.GetComponent<SpriteRenderer>().sprite);
            // Debug.Log(Battle.GetScene().Background);
            // BackgroundSprite.GetComponent<SpriteRenderer>().sprite = Battle.GetScene().Background;
        }

        public void LoadEnemySprite()
        {
            EnemySpriteResolver.SetCategoryAndLabel("Enemies", Battle.Enemies[0].Name);
            EnemySpriteResolver.ResolveSpriteToSpriteRenderer();
        }
        public void Update()
        {
            
        }

        public void UpdatePvOfList(List<Entity> BattleEntitiesList, GameObject EntityPvList)
        {
            for (int i = 0; i < BattleEntitiesList.Count; i++) {
                string entityLife = BattleEntitiesList[i].GetLifeString();
                GameObject EntityPvGroup = EntityPvList.transform.GetChild(i).gameObject;
                GameObject EntityPvLabel = EntityPvGroup.transform.GetChild(0).gameObject;
                TextMeshProUGUI EntityPvText = EntityPvLabel.GetComponent<TextMeshProUGUI>();
                EntityPvText.text = entityLife;
            }

        }
    }
}