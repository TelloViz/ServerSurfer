using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonResponse : MonoBehaviour
{
    [SerializeField] AppManager appManager;
    [SerializeField] PlayingStateAsset playingState;
   public void RespondToStartButton()
    {
        if(appManager.AppStateMachine.ContainsState(playingState.StateObject))
        {
            appManager.AppStateMachine.ChangeState(playingState.StateObject);
        }
        else
        {
            appManager.AppStateMachine.AddState(playingState.StateObject);
            appManager.AppStateMachine.ChangeState(playingState.StateObject);
        }
    }
}
