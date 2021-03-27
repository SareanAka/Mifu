using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] private int enemyHealth;
    public Animator animatior;
    private bool enemyJustGotHit = false;

    private void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile" && enemyJustGotHit == false)
        {
            enemyJustGotHit = true;
            DecreaseEnemyHealth();
            animatior.SetBool("ghostGotHit", true);
            StartCoroutine("Damage");
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator Damage()
    {
        yield return new WaitForSeconds(1.5f);
        enemyJustGotHit = false;
        animatior.SetBool("ghostGotHit", false);
    }

    public void DecreaseEnemyHealth()
    {
        
            enemyHealth -= 1;
            
    }

}
    
