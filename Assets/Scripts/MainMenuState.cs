using System;
using Vast.StateMachine;



[Serializable]
public class MainMenuState : State 
{
    public MainMenuState()
    {
        Name = "MainMenuState";
    }

    #region Class Methods
    public override void OnEnter() 
    {
        // Load MainMenuScene
        SceneLoader.Load(SceneLoader.Scene.MainMenuScene);
        
    }
    public override void OnExit() 
    {
        //unload main menu scene
        SceneLoader.Unload(SceneLoader.Scene.MainMenuScene);
    }
    public override void Update() { }
    public override void FixedUpdate() { }
    #endregion
}
