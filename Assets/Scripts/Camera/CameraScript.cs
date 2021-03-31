using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform transformShake;
    private static float shakeDuration = 0f;
    private float shakeMagnitude = 0.7f;
    private float dampingSpeed = 1.0f;
    [SerializeField] float cameraOffsetX;
    [SerializeField] float cameraOffsetY;

    public GameObject player;
    public static float xPos;
    float fraction = 0.08f;

    // The initial position of the GameObject
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Awake()
    {
        if (transformShake == null)
        {
            transformShake = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        initialPosition = transformShake.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (shakeDuration > 0)
        {
            transformShake.localPosition = new Vector3((CameraScript.xPos + 14), initialPosition.y, initialPosition.z) + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            xPos = player.gameObject.transform.position.x;

            Vector3 currentPos = transformShake.gameObject.transform.position;
            transformShake.gameObject.transform.position = Vector3.Lerp(currentPos, new Vector3(xPos + cameraOffsetX, cameraOffsetY, transform.position.z), fraction);

        }

    }

    public static void TriggerShake(float shakeTime)
    {
        shakeDuration = shakeTime;
    }
}
