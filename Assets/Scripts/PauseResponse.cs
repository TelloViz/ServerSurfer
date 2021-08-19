
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu]
public class PauseResponse : ScriptableObject
{
    [SerializeField] private AppManager appManager;
    [SerializeField] private State responseState;
    public void Respond()
    {
        // TODO currently 3 different things respond to this as I can see thsi message printed 3 times in a row every time I click pause
        Debug.Log("PausePressed responded to");
        if (appManager.AppStateMachine.ContainsState(responseState))
        {
            appManager.AppStateMachine.ChangeState(responseState);
        }
    }
}
