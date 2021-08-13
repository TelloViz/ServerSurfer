using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoSingleton<GameStateManager>
{
    [SerializeField] private AppManager stateMachine;

    [SerializeField] private MainMenuStateAsset mainMenuState;
    [SerializeField] private PlayingStateAsset playingState;
    [SerializeField] private PauseStateAsset pauseState;
    [SerializeField] private GameOverStateAsset gameOverState;

    [SerializeField] private MenuButton mainMenuStartButton;

    public AppManager StateMachine { get => stateMachine; set => stateMachine = value; }
    public MenuButton MainMenuStartButton { get => mainMenuStartButton; set => mainMenuStartButton = value; }

    private void Awake()
    {
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
