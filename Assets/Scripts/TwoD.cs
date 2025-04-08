using UnityEngine;

public class TwoD : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(moveX, moveY);
        transform.Translate(move * moveSpeed  * Time.deltaTime);

        // Clamp X position so player stays on the road
        float clampedX = Mathf.Clamp(transform.position.x, -2.5f, 2.5f);
        transform.position = new Vector2(clampedX, transform.position.y);
    }
}