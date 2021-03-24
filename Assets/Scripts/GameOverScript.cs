using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private string currentScene;
    private void Start()
    {
        currentScene = KillBox.sceneGameOver;
    }

    public void LoadRetry()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
