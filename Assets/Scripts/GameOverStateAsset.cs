using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameOverState", menuName = "States/GameOverState")]
public class GameOverStateAsset : ScriptableObject
{
    private GameOverState stateObject;

    GameOverStateAsset()
    {
        StateObject = new GameOverState();
        //Debug.Log("Hello from GameOverStateAsset()");
    }

    public GameOverState StateObject { get => stateObject; set => stateObject = value; }
}
