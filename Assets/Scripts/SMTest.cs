using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class SMTest : MonoBehaviour
{

    [SerializeField] private AppManager appMgr;
    // Start is called before the first frame update
    void Start()
    {
        appMgr.AppStateMachine.AddState(new MainMenuState());
        appMgr.AppStateMachine.AddState(new PlayingState());
        appMgr.AppStateMachine.OnStateChange += PrintDebug;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintDebug(State newState)
    {
        Debug.Log($"State changed to {newState.Name}");
    }
}
