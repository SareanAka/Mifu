using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesScript : KillBox
{
    private bool playerJustGotHit;


    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("MainChara") && playerJustGotHit == false)
        {
            if (PlayerShieldPower.isShieldActive == false)
            {
                SceneManager.LoadScene("Game Over");
            }
            else
            {
                CameraScript.TriggerShake(0.1f);
                playerJustGotHit = true;
                PlayerShieldPower.isShieldActive = false;
                StartCoroutine("PlayerHit");
            }
        }
    }

    private IEnumerator PlayerHit()
    {
        yield return new WaitForSeconds(1.0f);
        playerJustGotHit = false;
    }
}
