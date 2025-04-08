using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetPositionY = 0f;    // where it resets to the top
    public float lowerLimitY = -20f;     // how far down it scrolls

    void Update()
    {
        transform.Translate(Vector2.down * scrollSpeed * Time.deltaTime);

        if (transform.position.y <= lowerLimitY)
        {
            Vector3 newPos = transform.position;
            newPos.y = resetPositionY;
            transform.position = newPos;
        }
    }
}