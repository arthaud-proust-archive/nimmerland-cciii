using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Classes;
namespace Classes
{
    public enum DialogTypes { Before, After };
    public class BattleDialogController : MonoBehaviour
    {
        public BattleController BattleController { get; set; }

        public Scene Scene;

        public GameObject DialogGroup;
        public Button DialogBtn;
        public Text DialogAuthor;
        public Text DialogText;

        public DialogTypes DialogType { get; set; }
        private Dialog currentDialog;
        private int dialogStep = 0;

        // Start is called before the first frame update
        public void SetScene(Scene scene)
        {
            Scene = scene;
        }
        public void OpenDialog(DialogTypes dialogType)
        {
            DialogType = dialogType;
            dialogStep = 0;
            SetDialogVisible(true);
            DialogBtn.Select();
            UpdateDialog();
        }

        public void CloseDialog()
        {
            dialogStep = 0;
            SetDialogVisible(false);
            BattleController.HandleEndDialog(DialogType);
        }

        public void SetDialogVisible(bool visible)
        {
            DialogGroup.SetActive(visible);
        }
        public bool IsLastDialogReached()
        {
            return dialogStep == GetDialogsOfTypeUsed().Count;
        }


        public void UpdateDialog()
        {
            if (IsLastDialogReached())
            {
                CloseDialog();
            }
            else
            {
                BattleController.GetSceneControllerScript().UpdateVisibilityOfEnemySprite();
                UpdateDialodText();
            }
        }

        public List<Dialog> GetDialogsOfTypeUsed()
        {
            if (DialogTypes.After.Equals(DialogType))
            {
                return Scene.DialogsAfter;
            }
            else
            {
                return Scene.DialogsBefore;
            }
        }

        public void UpdateDialodText()
        {

            currentDialog = GetDialogsOfTypeUsed()[dialogStep];
            Debug.Log(currentDialog.Entity.Name);
            DialogAuthor.text = currentDialog.Entity.Name;
            DialogAuthor.color = currentDialog.Entity.DialogNameColor;
            DialogText.text = currentDialog.Text;
        }

        public void NextDialog()
        {
            dialogStep++;
            UpdateDialog();
        }
    }
}