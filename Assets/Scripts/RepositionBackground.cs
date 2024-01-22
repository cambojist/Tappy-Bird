using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionBackground : MonoBehaviour
{
    private const float Speed = 1;
    private const float Threshold = -2.64f;
    private Vector2 _startPos;

    void Start()
    {
        var sprite = GetComponent<SpriteRenderer>().sprite;
        _startPos = new Vector2(sprite.rect.x, sprite.rect.y);
    }

    void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector2.left);
        if (transform.position.x < Threshold)
        {
            transform.position = _startPos;
        }
    }
}
