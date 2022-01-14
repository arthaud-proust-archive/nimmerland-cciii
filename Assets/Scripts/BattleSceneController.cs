using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using Classes;


namespace Classes {
    public class BattleSceneController : MonoBehaviour
    {
        public BattleController BattleController { get; set; }

        public GameObject BattleGroup;
        public Button ActionToSelectFirst;
        public Button HeroSelectionToSelectFirst;


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