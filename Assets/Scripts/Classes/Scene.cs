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
        public List<string> Dialogs = new List<string>();

        // constructeur
        public Scene(string background, string music, List<string> dialogs)
        {
            Background = background;
            Music = music;
            Dialogs = dialogs;
        }

        public string GetBackground()
        {
            return Background;
        }

        public string GetMusic()
        {
            return Music;
        }

        public List<string> GetDialogs()
        {
            return Dialogs;
        }
    }
}
