using SO.States.GameStates;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName = "AppManager", menuName = "Managers/AppManager")]
public class AppManager : ScriptableObject
{
    [SerializeField] private StateMachine appStateMachine;
    [SerializeField] private State initialState;
    [SerializeField] private List<State> registeredStates;

    public StateMachine AppStateMachine { get => appStateMachine; set => appStateMachine = value; }

    #region Unity Methods

    private void OnEnable()
    {
        appStateMachine = new StateMachine();
        appStateMachine.AddStates(registeredStates.ToArray());
        appStateMachine.ChangeState(initialState);
        
    }

    #endregion

    #region Class Methods
    #endregion


}


// Design notes:

/* 
 
    States:         
+--------------+
+   MainMenu   + 
+   Playing    +
+   Pausing    +
+   GameOver   +
+   Quit       +
+--------------+

                          Origin:
Transistions:           Main Menu     Playing    Pausing     Game Over    Quit
+------------------+---------------+---------------------+-------------+---------+
|   Click Start    |    Playing    |  ---      |    ---    |    ---    |   !!!   |
|   Click Quit     |    Quit       |  ---      |    ---    |    ---    |   !!!   |
|   Select Quit    |    ---        |  ---      |   Quit    |   Quit    |   !!!   |
|   Select Menu    |    ---        |  ---      | Main Menu | Main Menu |   !!!   |
|   Game Lose      |    ---        | Game Over |    ---    |    ---    |   !!!   |
|   Press Pause    |    ---        | Pausing   |    ---    |    ---    |   !!!   |
|   Select Resume  |    ---        |  ---      |  Playing  |    ---    |   !!!   |
+------------------+-------------------------------------------------------------+
 
--- == Not Valid (Also could be represented as self loops because these inputs wouldn't cause a state change.
 !!! == Accept State

 
 
 */