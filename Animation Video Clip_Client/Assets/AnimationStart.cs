using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStart : MonoBehaviour
{
    public Rigidbody rb;

    public void AnimStart()
    {
        rb.useGravity = enabled;
    }
}
