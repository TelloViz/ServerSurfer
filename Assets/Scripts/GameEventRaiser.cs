using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventRaiser : MonoBehaviour
{
    [SerializeField] AppManager appManager;
    [SerializeField] GameEvent startButtonClickedEvent;
    [SerializeField] GameEvent settingsMenuButtonClickedEvent;
    [SerializeField] GameEvent quitButtonClickedEvent;

    public AppManager AppManager { get => appManager; set => appManager = value; }

    public void RaiseStartButtonClickedEvent()
    {
        startButtonClickedEvent.Raise();
    }

    public void RaiseSettingsMenuButtonClickedEvent()
    {
        settingsMenuButtonClickedEvent.Raise();
    }
    public void RaiseQuitButtonClickedEvent()
    {
        quitButtonClickedEvent.Raise();
    }
}
