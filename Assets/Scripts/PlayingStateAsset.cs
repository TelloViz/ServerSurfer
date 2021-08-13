using System;
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName = "PlayingState", menuName = "States/PlayingState")]

public class PlayingStateAsset : ScriptableObject
{
    private PlayingState stateObject;

    PlayingStateAsset()
    {
        StateObject = new PlayingState();
       // Debug.Log("Hello from PlayingStateAsset()");
    }

    public PlayingState StateObject { get => stateObject; set => stateObject = value; }
}
