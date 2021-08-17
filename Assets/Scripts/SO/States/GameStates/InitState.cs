using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
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
                LoadAssociatedSceneAsyncEditor();
            }
            
        }
        public override void OnExit() { }
        public override void Update() { }
        public override void FixedUpdate() { }
        #endregion
    }
}