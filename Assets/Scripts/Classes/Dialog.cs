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
        public Dialog(Entity entity, string text)
        {
            Entity = entity;
            Text = text;
        }
    }
}