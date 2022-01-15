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
    private BattleSceneController battleSceneControllerScript;
    
    public SceneControl SceneControl;
    private SceneControl sceneControlScript;


    // Start is called before the first frame update
    void Start()
    {
        dialogControllerScript = BattleDialogController.GetComponent<BattleDialogController>();
        battleSceneControllerScript = BattleSceneController.GetComponent<BattleSceneController>();
        sceneControlScript = SceneControl.GetComponent<SceneControl>();

        dialogControllerScript.BattleController = this;
        battleSceneControllerScript.BattleController = this;


        StartBattle(BattleToStart);
    }

    public void NextBattle()
    {
        if(battleId < Battles.Count )
        {
            StartBattle(battleId + 1);
        }
        else
        {
            sceneControlScript.LoadScene("StartMenu");
        }
    }
    public BattleSceneController GetBattleSceneControllerScript()
    {
        return battleSceneControllerScript;
    }

    // Public classes 
    public void StartBattle(int _battleId)
    {
        currentBattle = (Battle)Activator.CreateInstance(Battles[_battleId]);
        battleId = _battleId;

        dialogControllerScript.SetScene(currentBattle.GetScene());
        battleSceneControllerScript.SetBattle(currentBattle);
        battleSceneControllerScript.LoadBackgroundSprite();
        battleSceneControllerScript.LoadEnemySprite();

        battleSceneControllerScript.SetBattleGroupVisible(false);
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
            if (currentBattle.IsEnded())
            {
                HandleBattleEnded();
            }
            else
            {
                battleSceneControllerScript.UpdatePv();
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
            battleSceneControllerScript.UpdatePv();
            battleSceneControllerScript.ShowBattleGroup();
        } else if(dialogType.Equals(DialogTypes.After))
        {
            // passer à la scène suivante
            NextBattle();
        }
    }

    public void HandleBattleEnded()
    {
        if(currentBattle.IsWon())
        {
            battleSceneControllerScript.SetBattleGroupVisible(false);
            dialogControllerScript.OpenDialog(DialogTypes.After);
            if (currentBattle.ShouldSkipDialog())
            {
                dialogControllerScript.CloseDialog();
            }
        } else if(currentBattle.IsLost())
        {
            sceneControlScript.LoadScene("Gameover");
        }

    }

}
