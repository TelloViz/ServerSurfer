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
            LoadAssociatedScene();
        }
        public override void OnExit() { }
        public override void Update() { }
        public override void FixedUpdate() { }
        #endregion
    }
}