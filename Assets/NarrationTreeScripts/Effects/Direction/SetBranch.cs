using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree
{
    public class SetBranch : aEffect
    {

        public SuperCondition superCondition;
        public int newActiveBranch;

        public override void PlayEffect()
        {
            base.PlayEffect();

            superCondition.SetBranch(newActiveBranch);
        }

        public override void DefineLabel()
        {
            base.DefineLabel();

            gameObject.name = "Set Branch " + superCondition.gameObject.name + " (" + newActiveBranch + ")";
        }
    }

}