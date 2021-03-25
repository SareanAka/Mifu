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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MainChara"))
        {
            SceneManager.LoadScene("Game Over");
        }

        if (collision.gameObject.CompareTag("WoodBox"))
        {
            Destroy(collision.gameObject);
        }
    }
}
