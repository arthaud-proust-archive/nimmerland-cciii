using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Classes;
namespace Classes
{
    public class BattleDialogController : MonoBehaviour
    {

        public Scene Scene;

        public GameObject DialogGroup;
        public Button DialogBtn;
        public Text DialogAuthor;
        public Text DialogText;

        private Dialog currentDialog;
        private int dialogStep = 0;

        // Start is called before the first frame update
        
        public void SetScene(Scene scene)
        {
            Scene = scene;
        }
        public void OpenDialog()
        {
            SetDialogVisible(true);
            DialogBtn.Select();
            UpdateDialog();
        }

        public void SetDialogVisible(bool visible)
        {
            DialogGroup.SetActive(visible);
        }
        public bool IsLastDialogReached()
        {
            return dialogStep == Scene.GetDialogs().Count;
        }

        public void UpdateDialog()
        {
            if (IsLastDialogReached())
            {
                dialogStep = 0;
                SetDialogVisible(false);
            }
            else
            {
                currentDialog = Scene.GetDialogs()[dialogStep];
                Debug.Log(currentDialog.Entity.Name);
                DialogAuthor.text = currentDialog.Entity.Name;
                DialogAuthor.color = currentDialog.Entity.DialogNameColor;
                DialogText.text = currentDialog.Text;
            }
        }

        public void NextDialog()
        {
            dialogStep++;
            UpdateDialog();
        }
    }
}