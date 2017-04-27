using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class PreviousBranch : aEffect
    {
        public SuperCondition superCondition;

        public override void PlayEffect()
        {
            base.PlayEffect();

            superCondition.PreviousBranch();
        }

        public override void DefineLabel()
        {
            base.DefineLabel();

            gameObject.name = "Previous Branch " + superCondition.gameObject.name;
        }
    }

}