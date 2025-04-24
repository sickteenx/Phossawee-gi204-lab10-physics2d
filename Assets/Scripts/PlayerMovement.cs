using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d; //private variable

    float move; //store Input from player
    [SerializeField] float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb2d.linearVelocity = new Vector2(move * speed, rb2d.linearVelocity.y);
    }
}
