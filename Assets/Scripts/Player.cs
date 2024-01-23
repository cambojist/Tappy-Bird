using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 140f;

    private Rigidbody2D _playerRb;

    private void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerRb.AddForce(3f * Vector2.up, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        PlayerControl();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle")) GameManager.Instance.GameOver();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Trigger")) GameManager.Instance.ChangeScore(1);
    }

    private void PlayerControl()
    {
        if (Input.touchCount < 1) return;
        if (Input.GetTouch(0).phase != TouchPhase.Began) return;
        _playerRb.velocity = Vector2.zero;
        _playerRb.AddForce(upForce * Time.fixedDeltaTime * Vector2.up, ForceMode2D.Impulse);
    }
}