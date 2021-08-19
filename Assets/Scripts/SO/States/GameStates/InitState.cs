
using UnityEngine;
using Vast.StateMachine;

namespace SO.States.GameStates
{
    [CreateAssetMenu(fileName = "InitState", menuName = "States/Init State")]
    public class InitState : State
    {
        #region Class Methods
        public override void OnEnter() 
        {
            Debug.Log("InitState.OnEnter()");
            if(Application.isPlaying)
            {
                LoadAssociatedSceneAsync();
            }
            else if(Application.isEditor)
            {
                OpenAssociatedSceneInEditor();
            }


            
        }
        public override void OnExit() 
        {
            DisableSceneObjects();
        }
        public override void Update() { }
        public override void FixedUpdate() { }
        #endregion
    }
}