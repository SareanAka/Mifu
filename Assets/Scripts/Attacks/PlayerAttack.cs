using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Transform firePosition;
    [SerializeField] GameObject projectiles;
    private bool justFired;

    // Update is called once per frame
    void Update()
    {
        if (!justFired)
        {
            //get Input from player to fire projectile
            if (Input.GetButtonDown("Fire1"))
            {
                //spawn object
                //where to spawn the projectile
                Instantiate(projectiles, firePosition.position, firePosition.rotation);

                justFired = true;
                StartCoroutine("cooldown");
            }
        }
    }

    private IEnumerator cooldown()
    {
        yield return new WaitForSeconds(0.5f);
        justFired = false;
    }
}
