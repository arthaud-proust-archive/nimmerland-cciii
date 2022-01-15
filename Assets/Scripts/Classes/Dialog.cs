using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Classes;

namespace Classes
{
    public class Dialog
    {
        public Entity Entity;
        public string Text;
        public Dialog(Entity entity, string text, bool? entityVisible=null)
        {
            Entity = entity;
            Text = text;

            Debug.Log("enity null default?");
            Debug.Log(entityVisible);
            if (!(entityVisible is null) )
            {
                Entity.Visible = (bool)entityVisible;
                Debug.Log(entity.Visible);
            }
        }
    }
}