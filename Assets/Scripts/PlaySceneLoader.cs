using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneLoader : MonoBehaviour
{
    public void LoadPlayScene()
    {
        SceneLoader.Load(SceneLoader.Scene.PlayingScene);
    }
}
