
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu]
public class UnPauseResponse : ScriptableObject
{
    [SerializeField] private AppManager appManager;
    [SerializeField] private State responseState;
    public void Respond()
    {
        Debug.Log("UnPausePressed responded to");
        if (appManager.AppStateMachine.ContainsState(responseState))
        {
            appManager.AppStateMachine.ChangeState(responseState);
        }
    }
}
