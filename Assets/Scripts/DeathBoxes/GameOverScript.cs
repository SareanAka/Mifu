using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private string currentScene;
    private void Start()
    {
        currentScene = PlayerHealth.sceneGameOver;
        PlayerHealth.coinCounter = 0;
        PlayerShieldPower.amountOfCoinsCollected = 0;
        PlayerShieldPower.isShieldActive = false;
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
