using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Maximum left position the player can go")]
    public float movespeed = 5f;

    [Header("Movement Limits")]
    public float minX = -2.5f;
    public float maxX =  2.5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(moveX, moveY);
        transform.Translate(move * movespeed * Time.deltaTime);

        // Clamp X position so player stays on the road 
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector2(clampedX, transform.position.y);   
    }
}