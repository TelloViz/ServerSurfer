/* This file is responsible for raising the events corresponding to the buttons on the main menu being clicked.
 Unity has it's own UI Toolkit Input Event system, but I wasn't sure about that and made my own events anyway. So I use those.
The events and the responses are both ScriptableObjects that can be injected into a listener. */

using UnityEngine;
using UnityEngine.UIElements;

public class SettingsMenuUIHandler : MonoBehaviour
{
    public UIDocument UIDocument;

    private Button mainMenuButton;

    [SerializeField] private GameEvent mainMenubuttonClickEvent;

    public Button MainMenuButton { get => mainMenuButton; set => mainMenuButton = value; }

    void Start()
    {
        var root = UIDocument.rootVisualElement;

        MainMenuButton = root.Q<Button>("main-menu-button");
        MainMenuButton.clickable.clicked += MainMenuButtonClicked;

    }

    private void MainMenuButtonClicked()
    {
        mainMenubuttonClickEvent.Raise();
    }

}