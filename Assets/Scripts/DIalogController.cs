using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DIalogController : MonoBehaviour
{

    public BattleController BattleController;
    public Text DialogText;

    private int dialogStep;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void NextDialog()
    {
        dialogStep++;
        Debug.Log(BattleController.GetScene());
        // Debug.Log(BattleController.GetScene().GetDialogs()[dialogStep]);
        // DialogText.text = ;
    }
}
