using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleControl: MonoBehaviour
{
    // Start is called before the first frame update
        public void Select0() {
            Debug.Log("Attaque");
        }

    public void Select1()
    {
        //if (BattleController.GetTurn().GetEntity().type == hero2)
        if(true)
        {
            Debug.Log("Runden");
        }
        else
        {
            Debug.Log("Special 1");
        }

 
    }

    public void SetAction(string action)
    {
        Debug.Log(action);

    }

    public void Select2() {
        Debug.Log("Special 2");
    }

    public void Select3() {
        Debug.Log("Special 3");
    }
}
