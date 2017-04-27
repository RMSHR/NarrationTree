using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class SetRotation : aEffect
    {

        public Transform targetTransform;
        public Vector3 newRotation;

        public override void PlayEffect()
        {
            base.PlayEffect();

            targetTransform.rotation = Quaternion.Euler(newRotation);
        }

        public override void DefineLabel()
        {
            base.DefineLabel();

            gameObject.name = "Effect New Rotation " + targetTransform.gameObject.name + " (" + newRotation + ")";
        }
    }

}