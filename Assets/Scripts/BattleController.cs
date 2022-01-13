using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Classes;
using BattleClasses;

public class BattleController : MonoBehaviour
{
    private Battle currentBattle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Public classes 
    public void StartBattle(string battleType)
    {
        switch (battleType)
        {
            case "battle1":
                currentBattle = new Battle1();
                break;
            case "battle2":
                currentBattle = new Battle2();
                break;
            case "battle3":
                currentBattle = new Battle3();
                break;
            case "battle4":
                currentBattle = new Battle4();
                break;
            default:
                break;
        }
    }

    public Turn GetTurn()
    {
        return new Turn();
    }

    public Scene GetScene()
    {
        return new Scene();
    }

    public void SelectAction(string action)
    {

        //if (BattleController.GetTurn().GetEntity().type == hero2)
        if (true)
        {
            Debug.Log("Runden");
        }
        else
        {
            Debug.Log("Special 1");
        }
        Debug.Log(action);
    }

    public void SelectTarget(string action)
    {

    }
}
