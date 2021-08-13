using System;
using UnityEngine;
using Vast.StateMachine;


[Serializable]
public class PauseState : State
{

    public PauseState()
    {
        Name = "PauseState";
    }
    #region Class Methods
    public override void OnEnter() 
    {
        Debug.Log("PauseState.OnEnter()");
        SceneLoader.Load(SceneLoader.Scene.PausingScene);
    }
    public override void OnExit() 
    {
        Debug.Log("PauseState.OnExit()");
        SceneLoader.Unload(SceneLoader.Scene.PausingScene);
    }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
