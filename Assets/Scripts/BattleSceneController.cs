using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using Classes;


namespace Classes {
    public class BattleSceneController : MonoBehaviour
    {

        public GameObject PvGroup;

        private Battle Battle;


        public void SetBattle(Battle battle)
        {
            Battle = battle;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        public void UpdatePV()
        {
            for (int i = 0; i < Battle.Heroes.Count; i++) {
                string heroLife = Battle.Heroes[i].GetLifeString();
                GameObject HeroPvGroup = PvGroup.transform.GetChild(i).gameObject;
                GameObject HeroPvLabel = HeroPvGroup.transform.GetChild(0).gameObject;
                TextMeshProUGUI HeroPvText = HeroPvLabel.GetComponent<TextMeshProUGUI>();
                HeroPvText.text = heroLife;
            }
        }
    }
}