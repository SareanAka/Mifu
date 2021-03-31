using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldPower : MonoBehaviour
{
    [SerializeField] SpriteRenderer shield;

    public static bool isShieldActive;
    public static int amountOfCoinsCollected;
    

    // Update is called once per frame
    void Update()
    {
        
        if (amountOfCoinsCollected >= 5)
        {
            isShieldActive = true;
            amountOfCoinsCollected = 0;
        }

        if (isShieldActive)
        {
            shield.enabled = true;
        }
        else
        {
            shield.enabled = false;
        }
        
    }
}
