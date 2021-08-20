/* This file is responsible for raising the events corresponding to the buttons on the Pausing menu being clicked.
 Unity has it's own UI Toolkit Input Event system, but I wasn't sure about that and made my own events anyway. So I use those.
The events and the responses are both ScriptableObjects that can be injected into a listener. */

using UnityEngine;
using UnityEngine.UIElements;

public class PausingUIHandler : MonoBehaviour
{
    public UIDocument UIDocument;
    
    private Button pausingResumeButton;
    private Button pausingQuitButton;
    private Button pausingMainMenuButton;

    [SerializeField] private GameEvent resumeButtonClickEvent;
    [SerializeField] private GameEvent unPausePressEvent;
    [SerializeField] private GameEvent mainMenuButtonClickEvent;
    [SerializeField] private GameEvent quitButtonClickEvent;

    public Button PausingResumeButton { get => pausingResumeButton; set => pausingResumeButton = value; }
    public Button PausingQuitButton { get => pausingQuitButton; set => pausingQuitButton = value; }
    public Button PausingMainMenuButton { get => pausingMainMenuButton; set => pausingMainMenuButton = value; }

    void Start()
    {
        var root = UIDocument.rootVisualElement;

        PausingResumeButton = root.Q<Button>("resume-button");
        PausingResumeButton.clickable.clicked += ResumeButtonClicked;

        PausingQuitButton = root.Q<Button>("quit-button");
        PausingQuitButton.clickable.clicked += QuitButtonClicked;

        PausingMainMenuButton = root.Q<Button>("mainmenu-button");
        PausingMainMenuButton.clickable.clicked += MainMenuButtonClicked;


    }

    private void ResumeButtonClicked()
    {
        resumeButtonClickEvent.Raise();
    }

    private void MainMenuButtonClicked()
    {
        mainMenuButtonClickEvent.Raise();
    }

    private void QuitButtonClicked()
    {
        quitButtonClickEvent.Raise();
    }
}