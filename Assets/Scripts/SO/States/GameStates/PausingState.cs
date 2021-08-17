using System;
using UnityEngine;
using Vast.StateMachine;

namespace SO.States.GameStates
{
    [CreateAssetMenu(fileName = "PausingState", menuName = "States/Pausing State")]
    public class PausingState : State
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
                LoadAssociatedSceneAsyncEditor();
            }
        }
        public override void OnExit() { }
        public override void Update() { }
        public override void FixedUpdate() { }

        #endregion
    }
}