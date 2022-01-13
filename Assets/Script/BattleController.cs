using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HeroClasses;
using BossClasses;

public class BattleController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        List<int> Speeds =
 {
                Hero1.baseSpeed,
                Hero2.baseSpeed,
                Hero3.baseSpeed
            };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
