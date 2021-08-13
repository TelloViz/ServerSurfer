using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class PauseStateManager : MonoBehaviour
{
    [SerializeField] private GameStateManager stateManager;
    [SerializeField] private PauseStateAsset pauseStateAsset;

    public PauseStateAsset PauseStateAsset { get => pauseStateAsset; set => pauseStateAsset = value; }




    // Start is called before the first frame update
    void Start()
    {
       stateManager.StateMachine.AppStateMachine.AddState(PauseStateAsset.StateObject);
       stateManager.StateMachine.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in Playing State
        if (newState == PauseStateAsset.StateObject)
        {
            Debug.Log("Hello from PlayInitializer.CheckChangedState()!");
        }
    }
}
