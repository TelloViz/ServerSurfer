using SO.Variables;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Vast.StateMachine {
    [Serializable]
    public abstract class State : ScriptableObject {
        [SerializeField] private StringVariable name;
        [SerializeField] private AppManager appMgr;

        [SerializeField] private List<State> reachableStates;
        [SerializeField] private StringVariable associatedSceneName;


        #region Properties
        public StringVariable Name { get => name; set => name = value; }
        public StringVariable AssociatedSceneName { get => associatedSceneName; set => associatedSceneName = value; }
        public List<State> ReachableStates { get => reachableStates; set => reachableStates = value; }

        #endregion

        #region Class Methods
        public abstract void OnEnter();
        public abstract void OnExit();
        public abstract void Update();
        public abstract void FixedUpdate();

        virtual public void LoadAssociatedScene()
        {
            SceneManager.LoadScene(AssociatedSceneName.Value);
        }

        public void TransitionTo(State toState, List<State> reachables)
        {
            if (reachables.Contains(toState))
            {
                Debug.Log("reachables DOES contain toState");
                appMgr.AppStateMachine.ChangeState(toState);
            }
            else
            {
                Debug.Log("reachables DOES NOT contain toState");
            }

        }
        #endregion
    }
}