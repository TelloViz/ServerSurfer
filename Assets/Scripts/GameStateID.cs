using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameStateEnum", menuName = "States/GameStateEnum")]
public class GameStateID : ScriptableObject
{
    public enum StateID { MainMenu, Playing, Pausing, GameOver};

 }
