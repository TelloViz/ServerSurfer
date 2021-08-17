
using UnityEngine;
using Vast.StateMachine;

namespace SO.States.GameStates
{
    [CreateAssetMenu(fileName = "MainMenuState", menuName = "States/Main Menu State")]
    public class MainMenuState : State
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
        public override void OnExit() 
        { 
        }
        public override void Update() 
        {
        }
        public override void FixedUpdate() 
        {
        }

        
        #endregion
    }
}