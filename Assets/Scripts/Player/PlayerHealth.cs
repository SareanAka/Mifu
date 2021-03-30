using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private string currentScene;
    [SerializeField] private int playerHealth;
    static public string sceneGameOver;
    private bool playerJustGotHit;
    public static int currentHealth;
    public static int coinCounter;

    private void Start()
    {
        sceneGameOver = currentScene;
    }

    private void Update()
    {
        currentHealth = playerHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && playerJustGotHit == false)
        {
            playerJustGotHit = true;
            LoseHP();
            CameraScript.TriggerShake(0.3f);
            StartCoroutine("PlayerHit");
            if (playerHealth <= 0)
            {
                GameOver();
            }
        }
    }

    private IEnumerator PlayerHit()
    {
        yield return new WaitForSeconds(1.5f);
        playerJustGotHit = false;
    }

    private void LoseHP()
    {
        playerHealth -= 1;
    }

    private void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}