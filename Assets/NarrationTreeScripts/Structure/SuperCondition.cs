using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	[DisallowMultipleComponent]
	[AddComponentMenu("Paint/Structure/Super Condition")]
	public class SuperCondition : MonoBehaviour, iFindComponents, iFindInChildren, iTestCondition, iHasLabel {
		
		public enum BranchActivationEnum {
			Selector,
			Sequential
		};
		
		public BranchActivationEnum branchAction = BranchActivationEnum.Selector;
		
		public int activeBranch;
		
		protected List<aCondition> childConditions;
		
		protected List<Branch> branches;
		
		
		public void DefineLabel()
		{
			string conditionName = "";
			
			FindComponents();

            foreach (aCondition c in childConditions)
			{
				conditionName += " ? ["+c.GetConditionLabel()+"]";
			}
			
			gameObject.name = "Condition"+conditionName;
        }
		
		void Awake() {
			FindComponents();
			FindInChildren();
            InitSelectorGameObjects();

        }

        // --------------------------------
        // Conditions asking
        // --------------------------------

        public void FindComponents()
		{
			aCondition[] _conditions = GetComponents<aCondition>();
			
			childConditions = new List<aCondition>();
			
			foreach(aCondition c in _conditions)
			{
				childConditions.Add(c);
			}
		}
		
		public void FindInChildren()
		{
			Branch[] _branches = GetComponentsInChildren<Branch>();
			
			branches = new List<Branch>();
			
			foreach(Branch b in _branches)
			{
				branches.Add(b);
			}
		}
		
		public bool TestCondition()
		{
			// if one child condition is false, return false
			foreach(aCondition c in childConditions)
			{
				if (!c.TestCondition())
					return false;
			}
			
			// if all conditions are true, return true
			return true;
		}

        // --------------------------------
        // Effect Activation
        // --------------------------------

        public void ActiveBranchEffects()
        {
            if (branchAction == BranchActivationEnum.Selector)
                SelectorActivation();
            else
                SequentialActivation();

        }

        void InitSelectorGameObjects()
        {
            /*foreach (Branch b in branches)
            {
                b.gameObject.SetActive(false);
            }
            branches[activeBranch].gameObject.SetActive(true);*/
        }

        void SelectorActivation()
        {
            InitSelectorGameObjects();

            branches[activeBranch].ActiveEffects();
        }

        void SequentialActivation()
        {
            foreach (Branch b in branches)
            {
                b.ActiveEffects();
            }
        }

        // --------------------------------
        // Branch Actions
        // --------------------------------

        public void NextBranch()
        {
            int _newBranch = activeBranch + 1;

            if (_newBranch >= branches.Count)
                activeBranch = 0;
            else
                activeBranch = _newBranch;

            InitSelectorGameObjects();
        }

        public void PreviousBranch()
        {
            int _newBranch = activeBranch - 1;

            if (_newBranch < 0)
                activeBranch = branches.Count - 1;
            else
                activeBranch = _newBranch;

            InitSelectorGameObjects();
        }

        public void SetBranch(int _newBranch)
        {
            if (_newBranch < 0 || _newBranch >= branches.Count)
                _newBranch = 0;

            activeBranch = _newBranch;

            InitSelectorGameObjects();
        }
    }

}
