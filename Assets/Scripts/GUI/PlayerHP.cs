using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI HPCounter;

    // Update is called once per frame
    void Update()
    {
        HPCounter.text = "Health: " + PlayerHealth.currentHealth;
    }
}
