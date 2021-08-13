using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PauseState", menuName = "States/PauseState")]
public class PauseStateAsset : ScriptableObject
{
    private PauseState stateObject;

    PauseStateAsset()
    {
        StateObject = new PauseState();
        //Debug.Log("Hello from PauseStateAsset()");
    }

    public PauseState StateObject { get => stateObject; set => stateObject = value; }
}
