/* This file is responsible for raising the events corresponding to the buttons on the play state UI being clicked.
 Unity has it's own UI Toolkit Input Event system, but I wasn't sure about that and made my own events anyway. So I use those.
The events and the responses are both ScriptableObjects that can be injected into a listener. */

using UnityEngine;
using UnityEngine.UIElements;

public class PlayingUIHandler : MonoBehaviour
{
    public UIDocument UIDocument;

    private Button playingPauseButton;

    [SerializeField] private GameEvent pauseButtonClickEvent;

    public Button PlayingPauseButton { get => playingPauseButton; set => playingPauseButton = value; }

    void Start()
    {
        var root = UIDocument.rootVisualElement;

        PlayingPauseButton = root.Q<Button>("pause-button");
        PlayingPauseButton.clickable.clicked += PauseButtonClicked;


    }

    private void PauseButtonClicked()
    {
        pauseButtonClickEvent.Raise();
    }
}