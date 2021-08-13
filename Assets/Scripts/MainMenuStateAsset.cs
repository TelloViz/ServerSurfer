using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainMenuState", menuName = "States/MainMenuState")]
public class MainMenuStateAsset : ScriptableObject
{
    private MainMenuState stateObject;

    MainMenuStateAsset()
    {
        StateObject = new MainMenuState();
        //Debug.Log("Hello from MainMenuStateAsset()");
    }

    public MainMenuState StateObject { get => stateObject; set => stateObject = value; }
}
