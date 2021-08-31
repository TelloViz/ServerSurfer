using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName ="DebugData", menuName ="Debug/Debug Data")]
public class DebugData : ScriptableObject
{
    [SerializeField] private AppManager appManager;
    int numRegisteredStates;
    List<string> stateNameStrings;

    public int NumRegisteredStates { get => numRegisteredStates; set => numRegisteredStates = value; }
    public List<string> StateNameStrings { get => stateNameStrings; set => stateNameStrings = value; }
}