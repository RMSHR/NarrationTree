using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class IsActive : aCondition
    {

        public override bool TestCondition()
        {
            return gameObject.activeSelf;
        }

        public override string GetConditionLabel()
        {

            return "Is Active ?";
        }
    }

}