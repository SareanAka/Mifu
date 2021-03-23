using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Canvas canvas = null;
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
    private void OnCollisionEnter2D()
    {
        canvas.enabled = true;
        Debug.Log("u ded");
    }
}
