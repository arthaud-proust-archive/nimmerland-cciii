using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Classes;

namespace Classes
{

    public class TestClass : TestClassParent
    {
        public TestClass() : base()
        {
        }
    }

    public class TestClassParent
    {
        public int Id;
        public TestClassParent()
        {
            Id = 4;
        }
    }
    public class Hero : Entity
    {
        public new EntityTypes EntityType = EntityTypes.Hero;

        public Hero() : base() { }


        public virtual void getAction()
        {

        }

        public virtual void FirstCapacity()
        {

        }

        public virtual void SecondCapacity()
        {

        }

        public virtual void ThirdCapacity()
        {

        }

    }
}
