/* This file is responsible for raising the events corresponding to the buttons on the main menu being clicked.
 Unity has it's own UI Toolkit Input Event system, but I wasn't sure about that and made my own events anyway. So I use those.
The events and the responses are both ScriptableObjects that can be injected into a listener. */

using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuUIHandler : MonoBehaviour
{
    public UIDocument UIDocument;
    
    private Button mainMenuStartButton;
    private Button mainMenuExitButton;

    [SerializeField] private GameEvent startButtonClickEvent;
    [SerializeField] private GameEvent exitButtonClickEvent;

    public Button MainMenuStartButton { get => mainMenuStartButton; set => mainMenuStartButton = value; }
    public Button MainMenuExitButton { get => mainMenuExitButton; set => mainMenuExitButton = value; }

    void Start()
    {
        var root = UIDocument.rootVisualElement;

        MainMenuStartButton = root.Q<Button>("start-button");
        MainMenuStartButton.clickable.clicked += StartButtonClicked;

        MainMenuExitButton = root.Q<Button>("exit-button");
        MainMenuExitButton.clickable.clicked += ExitButtonClicked;


    }

    private void StartButtonClicked()
    {
        startButtonClickEvent.Raise();
    }

    private void ExitButtonClicked()
    {
        exitButtonClickEvent.Raise();
    }
}