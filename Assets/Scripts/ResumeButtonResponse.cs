/* This file is a button click response method wrapped in an SO.
 The purpose is to inject via the inspector, into any listener that needs to access this sort of response
I have many duplicates of this type of thing and need to consolodate to a single StateResponse So*/

// TODO: Unify response SO types under a single umbrella
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu]
public class ResumeButtonResponse : ScriptableObject
{
    [SerializeField] private AppManager appManager;
    [SerializeField] private State responseState;
    public void Respond()
    {
        Debug.Log("QuitButton responded to");
        if (appManager.AppStateMachine.ContainsState(responseState))
        {
            appManager.AppStateMachine.ChangeState(responseState);
        }
    }
}
