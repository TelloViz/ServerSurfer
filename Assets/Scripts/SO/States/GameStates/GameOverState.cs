using System;
using UnityEngine;
using Vast.StateMachine;

namespace SO.States.GameStates
{
    [CreateAssetMenu(fileName = "GameOverState", menuName = "States/Game Over State")]
    public class GameOverState : State
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