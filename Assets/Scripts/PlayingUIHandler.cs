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