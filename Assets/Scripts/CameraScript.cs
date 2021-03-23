using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float xPos;
    float fraction = 0.08f;

    // Start is called before the first frame update
    void Start()
    {
        xPos = this.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xPos = player.gameObject.transform.position.x;

            Vector3 currentPos = this.gameObject.transform.position;
            Vector3 des = player.gameObject.GetComponent<Transform>().position;
            this.gameObject.transform.position = Vector3.Lerp(currentPos, new Vector3(xPos + 13, transform.position.y, transform.position.z), fraction);
    }
}
