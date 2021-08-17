using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vast.StateMachine;

public class StateMachineInitializer : MonoBehaviour
{

    [SerializeField] private AppManager appManager;
    [SerializeField] private State associatedState;
    [SerializeField] private List<State> statesToRegister;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("StateMachineInitializer.Start()");


        // If appManager has a list of registered states,
        // then we will add them all to the machine
        if (statesToRegister.Any<State>())
        {
            Debug.Log("StateMachineInitializer: There ARE states to register");
            appManager.AppStateMachine.AddStates(statesToRegister.ToArray());

            
        }

        // Right now there is no initialization to be done
        // other than transitioning to the actual first state...
        if (associatedState.ReachableStates.Any())
        {
            Debug.Log("There is a reachable state to transition to from InitState \n State Reachable: " + associatedState.ReachableStates.First<State>().ToString());
       
            associatedState.TransitionTo(associatedState.ReachableStates.First<State>(), associatedState.ReachableStates);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
