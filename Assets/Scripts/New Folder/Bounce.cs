using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceHeight = 0.5f;
    public float bounceSpeed = 2f;
    private Vector3 startPos;

    void Start()
    {   
        startPos = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
        transform.position = startPos + new Vector3(0, newY, 0);
    }
}