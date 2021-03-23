using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private Canvas canvas = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.enabled)
            {
                canvas.enabled = false;
            }
            else if (!canvas.enabled)
            {
                canvas.enabled = true;
            }

        }
    }
    public void ReturnToGame()
    {
        canvas.enabled = false;
    }
}

