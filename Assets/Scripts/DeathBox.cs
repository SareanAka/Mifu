using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : KillBox
{
    public GameObject player;
    public float xPos;

    // Start is called before the first frame update
    void Start()
    {
        xPos = this.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xPos = player.gameObject.transform.position.x;
        this.transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
