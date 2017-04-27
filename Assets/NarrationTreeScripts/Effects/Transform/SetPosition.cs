using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class SetPosition : aEffect
    {

        public Transform targetTransform;
        public Vector3 newPosition;

        public override void PlayEffect()
        {
            base.PlayEffect();

            targetTransform.position = newPosition;
        }

        public override void DefineLabel()
        {
            base.DefineLabel();

            gameObject.name = "Effect New Position " + targetTransform.gameObject.name + " (" + newPosition + ")";
        }
    }

}