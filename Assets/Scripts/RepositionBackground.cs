using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RepositionBackground : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float threshold;
    [SerializeField]
    private Vector2 startPos;

    void Start()
    {
        var sprite = GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);
        if (transform.position.x < threshold)
        {
            transform.position = startPos;
        }
    }
}
