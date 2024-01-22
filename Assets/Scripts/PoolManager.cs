using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static readonly List<GameObject> ObjectsPool = new ();

    public static GameObject SpawnObject(GameObject go, Vector2 spawnPosition, Quaternion spawnRotation)
    {
        var spawnGo = ObjectsPool.FirstOrDefault();

        if (spawnGo is null)
        {
            spawnGo = Instantiate(go, spawnPosition, spawnRotation);
        }
        else
        {
            spawnGo.transform.position = spawnPosition;
            spawnGo.transform.rotation = spawnRotation;
            ObjectsPool.Remove(spawnGo);
            spawnGo.SetActive(true);
        }

        return spawnGo;
    }

    public static void ReturnObjectToPool(GameObject go)
    {
        go.SetActive(false);
        ObjectsPool.Add(go);
    }
}
