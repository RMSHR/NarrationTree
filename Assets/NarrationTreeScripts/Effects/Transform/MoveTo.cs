using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class MoveTo : aEffect
    {
        public Transform targetTransformToMove;
        public Transform targetTransformPosition;
        public float speed = 1f;

        public override void PlayEffect()
        {
            base.PlayEffect();

            targetTransformToMove.position = Vector3.MoveTowards(targetTransformToMove.position, targetTransformPosition.position, Time.deltaTime * speed);
        }

        public override void DefineLabel()
        {
            base.DefineLabel();

            gameObject.name = "Effect Move "+ targetTransformToMove .gameObject.name+ " To " + targetTransformPosition.position;
        }
    }
}
