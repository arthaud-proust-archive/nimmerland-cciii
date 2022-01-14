using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Classes;

namespace Classes
{
    public class Scene
    {
        public string Background;
        public string Music;
        public List<Dialog> Dialogs = new List<Dialog>();

        // constructeur
        public Scene(string background, string music, List<Dialog> dialogs)
        {
            Background = background;
            Music = music;
            Dialogs = dialogs;
            Debug.Log(background);
        }

        public string GetBackground()
        {
            return Background;
        }

        public string GetMusic()
        {
            return Music;
        }

        public List<Dialog> GetDialogs()
        {
            return Dialogs;
        }
    }
}
