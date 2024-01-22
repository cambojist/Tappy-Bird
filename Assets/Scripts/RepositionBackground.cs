using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionBackground : MonoBehaviour
{
    private const float Speed = 1;
    private const float Threshold = -2.64f;
    private static readonly Vector2 StartPos = new(2.86f, 0);

    void Start()
    {
        var sprite = GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector2.left);
        if (transform.position.x < Threshold)
        {
            transform.position = StartPos;
        }
    }
}
