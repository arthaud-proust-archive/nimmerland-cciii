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
        public bool? EntityVisible;
        public Dialog(Entity entity, string text, bool? entityVisible=null)
        {
            Entity = entity;
            Text = text;
            EntityVisible = entityVisible;
        }

        public void UpdateEntityVisibility()
        {
            if (!(EntityVisible is null))
            {
                Entity.Visible = (bool)EntityVisible;
            }
        }
    }
}