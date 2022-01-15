using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Classes;

namespace Classes
{
    public class Scene
    {
        public Sprite Background { get; set; }

        public string Music { get; set; }
        public List<Dialog> DialogsBefore { get; set; }
        public List<Dialog> DialogsAfter { get; set; }

        // constructeur
        public Scene(Sprite background, string music, List<Dialog> dialogsBefore, List<Dialog> dialogsAfter)
        {
            
            Background = background;
            Music = music;
            DialogsBefore = dialogsBefore;
            DialogsAfter = dialogsAfter;
            Debug.Log(background);
        }


    }
}
