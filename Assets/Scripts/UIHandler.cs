using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
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