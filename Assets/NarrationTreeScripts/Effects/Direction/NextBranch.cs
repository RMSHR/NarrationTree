using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class NextBranch : aEffect
    {

        public SuperCondition superCondition;

        public override void PlayEffect()
        {
            base.PlayEffect();

            superCondition.NextBranch();
        }

        public override void DefineLabel()
        {
            base.DefineLabel();

            gameObject.name = "Next Branch " + superCondition.gameObject.name;
        }
    }

}