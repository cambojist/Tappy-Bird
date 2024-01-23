using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float time = 4f;
    [SerializeField] private GameObject pipe;
    [SerializeField] private GameObject pipeTrigger;
    [SerializeField] private float spawnX = 4;
    [SerializeField] private float maxY = -3;
    [SerializeField] private float minY = -6;

    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            var y = Random.Range(minY, maxY);
            PoolManager.SpawnObject(pipe, new Vector2(spawnX, y), Quaternion.identity);
            PoolManager.SpawnObject(pipe, new Vector2(spawnX, y + 10), Quaternion.Euler(180, 0, 0));
            PoolManager.SpawnObject(pipeTrigger, new Vector2(spawnX, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}