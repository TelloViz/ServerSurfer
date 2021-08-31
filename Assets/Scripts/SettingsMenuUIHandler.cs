<<<<<<< HEAD
﻿/* This file is responsible for raising the events corresponding to the buttons on the main menu being clicked.
=======
/* This file is responsible for raising the events corresponding to the buttons on the play state UI being clicked.
>>>>>>> main
 Unity has it's own UI Toolkit Input Event system, but I wasn't sure about that and made my own events anyway. So I use those.
The events and the responses are both ScriptableObjects that can be injected into a listener. */

using UnityEngine;
using UnityEngine.UIElements;

public class SettingsMenuUIHandler : MonoBehaviour
{
    public UIDocument UIDocument;

    private Button mainMenuButton;

<<<<<<< HEAD
    [SerializeField] private GameEvent mainMenubuttonClickEvent;

    public Button MainMenuButton { get => mainMenuButton; set => mainMenuButton = value; }
=======
    [SerializeField] private GameEvent mainMenuButtonClickedEvent;

    public Button MainMenuButton { get => mainMenuButton; set => mainMenuButton = value; }
    public GameEvent MainMenuButtonClickedEvent { get => mainMenuButtonClickedEvent; set => mainMenuButtonClickedEvent = value; }
>>>>>>> main

    void Start()
    {
        var root = UIDocument.rootVisualElement;

        MainMenuButton = root.Q<Button>("main-menu-button");
        MainMenuButton.clickable.clicked += MainMenuButtonClicked;

<<<<<<< HEAD
=======

>>>>>>> main
    }

    private void MainMenuButtonClicked()
    {
<<<<<<< HEAD
        mainMenubuttonClickEvent.Raise();
    }

=======
        MainMenuButtonClickedEvent.Raise();
    }
>>>>>>> main
}