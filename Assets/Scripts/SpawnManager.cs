using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private float time = 4f;
    [SerializeField]
    private GameObject pipe;

    [SerializeField] 
    private float spawnX = 4;
    [SerializeField] 
    private float maxY = -3;
    [SerializeField] 
    private float minY = -6;
    
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }
    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            var y = Random.Range(minY, maxY);
            PoolManager.SpawnObject(pipe, new Vector2(spawnX, y), Quaternion.identity);
            PoolManager.SpawnObject(pipe, new Vector2(spawnX, y + 10), Quaternion.Euler(180, 0, 0));
        }
    }
}
