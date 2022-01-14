using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DIalogController : MonoBehaviour
{

    public BattleController BattleController;
    public BattleController BattleControllerScript;
    public Text DialogText;

    private int dialogStep;

    // Start is called before the first frame update
    void Start()
    {
        BattleControllerScript = BattleController.GetComponent<BattleController>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void NextDialog()
    {
        dialogStep++;
        Debug.Log(BattleController.GetScene().Background);
        // Debug.Log(BattleController.GetScene().GetDialogs()[dialogStep]);
        DialogText.text = BattleControllerScript.GetScene().GetDialogs()[dialogStep];
    }
}
