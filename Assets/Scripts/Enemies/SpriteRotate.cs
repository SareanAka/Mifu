using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SpriteRotate : MonoBehaviour
{
    public AIPath aiPath;
    [SerializeField] private SpriteRenderer localSprite;

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            localSprite.flipX = true;
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            localSprite.flipX = false;
        }
    }
}
