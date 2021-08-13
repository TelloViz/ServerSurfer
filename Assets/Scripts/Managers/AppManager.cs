using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName = "AppManager", menuName = "Managers/AppManager")]
public class AppManager : ScriptableObject
{
    [SerializeField] private StateMachine appStateMachine;

    public StateMachine AppStateMachine { get => appStateMachine; set => appStateMachine = value; }

    private void Awake()
    {
        appStateMachine = new StateMachine();
    }


}