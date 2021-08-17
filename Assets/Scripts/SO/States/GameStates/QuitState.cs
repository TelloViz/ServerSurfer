using System;
using UnityEngine;
using Vast.StateMachine;

namespace SO.States.GameStates
{
    [CreateAssetMenu(fileName = "QuitState", menuName = "States/Quit State")]
    public class QuitState : State
    {
        #region Class Methods
        public override void OnEnter() 
        {
            if (Application.isPlaying)
            {
                LoadAssociatedSceneAsync();
            }
            else if (Application.isEditor)
            {
                OpenAssociatedSceneInEditor();
            }
        }
        public override void OnExit() { }
        public override void Update() { }
        public override void FixedUpdate() { }
        #endregion
    }
}