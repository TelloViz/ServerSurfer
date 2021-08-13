using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class GameOverStateManager : MonoBehaviour
{
    [SerializeField] private GameStateManager stateManager;
    [SerializeField] private GameOverStateAsset gameOverStateAsset;

    public GameOverStateAsset GameOverStateAsset { get => gameOverStateAsset; set => gameOverStateAsset = value; }




    // Start is called before the first frame update
    void Start()
    {
        stateManager.StateMachine.AppStateMachine.AddState(GameOverStateAsset.StateObject);
        stateManager.StateMachine.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in Playing State
        if (newState == GameOverStateAsset.StateObject)
        {
            Debug.Log("Hello from PlayInitializer.CheckChangedState()!");
        }
    }
}
