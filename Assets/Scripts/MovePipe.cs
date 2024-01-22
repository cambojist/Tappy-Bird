using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] 
    private float speed = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.left);    
    }
}
