using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class PlayStateManager : MonoBehaviour
{
    [SerializeField] private GameStateManager stateManager;

    [SerializeField] private PlayingStateAsset playingStateAsset;

    public PlayingStateAsset PlayingStateAsset { get => playingStateAsset; set => playingStateAsset = value; }


    
    void OnEnable()
    {
        stateManager.StateMachine.AppStateMachine.AddState(PlayingStateAsset.StateObject);
        stateManager.StateMachine.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in Playing State
        if (newState == PlayingStateAsset.StateObject)
        {
            Debug.Log("Hello from PlayInitializer.CheckChangedState()!");
            ActivateStateObjects();
        }
    }

    void ActivateStateObjects()
    {
        foreach (Transform child in transform)
            child.gameObject.SetActive(true);
    }
}
