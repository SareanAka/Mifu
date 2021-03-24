using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour
{
    [SerializeField] private string currentScene;
    static public string sceneGameOver;

    private void Start()
    {
        sceneGameOver = currentScene;
    }

    private void OnCollisionEnter2D()
    {
        SceneManager.LoadScene("Game Over");
    }
}
