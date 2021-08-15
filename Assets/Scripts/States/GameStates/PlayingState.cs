using System;
using Vast.StateMachine;

namespace States.GameStates
{
    [Serializable]
    public class PlayingState : State
    {
        PlayingState()
        {
            Name = "PlayingState";
        }
        #region Class Methods
        public override void OnEnter() { }
        public override void OnExit() { }
        public override void Update() { }
        public override void FixedUpdate() { }
        #endregion
    }
}