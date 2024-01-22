using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float upForce = 140f;
    
    private Rigidbody2D _playerRb;
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerRb.AddForce(3f * Vector2.up, ForceMode2D.Impulse);
    }

    void FixedUpdate()
    {
        //TODO: Temporary solution for testing purpose
        if (transform.position.y < -5)
        {
            transform.position = new Vector2(0, -4.5f);
            _playerRb.velocity = Vector2.zero;
        }
        
        if (Input.touchCount < 1) return;
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _playerRb.velocity = Vector2.zero;
            _playerRb.AddForce(upForce * Time.fixedDeltaTime * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
