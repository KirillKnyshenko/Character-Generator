using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartIndicator : MonoBehaviour
{
    public BodyParts.Kind kind;
    public Vector2 startPos;

    public void Start()
    {
        startPos = transform.localPosition;
    }
}
