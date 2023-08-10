using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 2;

    public bool arrows = false;

    void Update() {
        if (arrows) {
           inputHandle(KeyCode.UpArrow, KeyCode.DownArrow);
        } else {
            inputHandle(KeyCode.W, KeyCode.S);
        }
    }
    void inputHandle(KeyCode up, KeyCode down) {
        if (Input.GetKey(up)) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        } else if (Input.GetKey(down)) {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
