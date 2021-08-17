using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vast.StateMachine;

public class StateMachineInitializer : MonoBehaviour
{

    [SerializeField] private AppManager appManager;
    [SerializeField] private State associatedState;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("StateMachineInitializer.Start()");
        // Right now there is no initialization to be done
        // other than transitioning to the actual first state...
        if (associatedState.ReachableStates.Any())
        {
            associatedState.TransitionTo(associatedState.ReachableStates.First<State>(), associatedState.ReachableStates);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
