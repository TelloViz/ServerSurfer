using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    public enum Scene           // Note: Spelling of enum fields matter
    {
        MainMenuScene, 
        PlayingScene, 
        PausingScene, 
        GameOverScene
    }

    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public static void Unload(Scene scene)
    {
        SceneManager.UnloadSceneAsync(scene.ToString());
    }
}
