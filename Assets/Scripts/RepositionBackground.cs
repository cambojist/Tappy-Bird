using UnityEngine;

public class RepositionBackground : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float threshold;

    [SerializeField] private Vector2 startPos;

    private void Start()
    {
        var sprite = GetComponent<SpriteRenderer>().sprite;
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);
        if (transform.position.x < threshold) transform.position = startPos;
    }
}