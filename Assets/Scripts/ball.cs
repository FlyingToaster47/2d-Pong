using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 2f;
    public float maxSpeed = 5f;
    public Vector2 direction = new Vector2(1, 1);
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.layer == 8) {
            float player_y = collision.gameObject.transform.position.y;
            float hitPos = transform.position.y - player_y;

            if (hitPos < 0.3) {
                direction.y = -1;
            } else if (hitPos > 0.7) {
                direction.y = 1;
            }
            direction.x *= -1;
            if (speed < maxSpeed) {
                speed = speed * 1.1f;
            }
        } else if (collision.gameObject.layer == 9) {
            if (collision.gameObject.name == "TopBoundary") {
                direction.y = -1;
            } else {
                direction.y = 1;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D co) {
        transform.position = new Vector3(0, 0, 0);
        speed = 2f;
    }
}