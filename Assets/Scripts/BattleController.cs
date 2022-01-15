using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Classes;
using BattleClasses;

public class BattleController : MonoBehaviour
{
    public int BattleToStart;
    private int battleId;

    private List<Type> Battles = new List<Type> { 
        typeof(Battle1), 
        typeof(Battle2), 
        typeof(Battle3)
    };
    private Battle currentBattle;

    public Button FirstSelectHeroBtn;
    public Button FirstSelectActionBtn;
    public Text DialogText;

    public BattleDialogController BattleDialogController;
    private BattleDialogController dialogControllerScript;

    public BattleSceneController BattleSceneController;
    private BattleSceneController sceneControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        dialogControllerScript = BattleDialogController.GetComponent<BattleDialogController>();
        sceneControllerScript = BattleSceneController.GetComponent<BattleSceneController>();

        dialogControllerScript.BattleController = this;
        sceneControllerScript.BattleController = this;


        StartBattle(BattleToStart);
    }

    public void NextBattle()
    {
        StartBattle(battleId+1);
    }
    public BattleSceneController GetSceneControllerScript()
    {
        return sceneControllerScript;
    }

    // Public classes 
    public void StartBattle(int _battleId)
    {
        currentBattle = (Battle)Activator.CreateInstance(Battles[_battleId]);
        battleId = _battleId;

        dialogControllerScript.SetScene(currentBattle.GetScene());
        sceneControllerScript.SetBattle(currentBattle);
        sceneControllerScript.LoadBackgroundSprite();
        sceneControllerScript.LoadEnemySprite();

        sceneControllerScript.SetBattleGroupVisible(false);
        dialogControllerScript.OpenDialog(DialogTypes.Before);
        if(currentBattle.ShouldSkipDialog())
        {
            dialogControllerScript.CloseDialog();
        }
    }

    public Turn GetTurn()
    {
        return currentBattle.GetTurn();
    }
    
    public Scene GetScene()
    {
        return currentBattle.GetScene();
    }

    public void SelectAction(string action)
    {

        //if (BattleController.GetTurn().GetEntity().type == hero2)
        currentBattle.GetTurn().Action = action;
        
        if (action == "Special1" || action == "Special3")
        {
            FirstSelectHeroBtn.Select();
        } else
        {
            currentBattle.EndTurn();
            Debug.Log(currentBattle.IsEnded());
            if (currentBattle.IsEnded())
            {
                HandleBattleEnded();
            }
            else
            {
                sceneControllerScript.UpdatePv();
                currentBattle.BeginTurn();
            }
        }
    }

    public void SelectTarget(string target)
    {
        currentBattle.GetTurn().Target = target;
        //if (BattleController.GetTurn().GetEntity().type == hero2)

        Debug.Log(target);

        FirstSelectActionBtn.Select();
    }

    public void HandleEndDialog(DialogTypes dialogType)
    {
        if(dialogType.Equals(DialogTypes.Before))
        {
            currentBattle.BeginTurn();
            sceneControllerScript.UpdatePv();
            sceneControllerScript.ShowBattleGroup();
        } else if(dialogType.Equals(DialogTypes.After))
        {
            // passer à la scène suivante
            NextBattle();
        }
    }

    public void HandleBattleEnded()
    {
        sceneControllerScript.SetBattleGroupVisible(false);
        dialogControllerScript.OpenDialog(DialogTypes.After);
        if (currentBattle.ShouldSkipDialog()) { 
            dialogControllerScript.CloseDialog();
        }
    }

}
