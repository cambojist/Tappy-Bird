using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private readonly float _despawnPosX = -6;

    private void Update()
    {
        MoveLeft();
        DespawnPipe();
    }

    private void DespawnPipe()
    {
        if (transform.position.x > _despawnPosX) return;
        PoolManager.ReturnObjectToPool(gameObject);
    }

    private void MoveLeft()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);
    }
}