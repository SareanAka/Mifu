using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectScript : MonoBehaviour
{

    private bool collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "MainChara")
        {
            if (collected == false)
            {
                collected = true;
                Destroy(gameObject);
                PlayerHealth.coinCounter += 1;
                StartCoroutine("Collected");
            }
        }
    }
    private IEnumerator Collected()
    {

        yield return new WaitForSeconds(0.01f);
        collected = false;
    }
}
