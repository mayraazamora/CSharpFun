using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public float rotationSpeed = 180f; // degrees per second
    public float pulseSpeed = 2f;
    public float pulseAmount = 0.1f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Rotate
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Pulse scale
        float scale = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = originalScale * scale;
    }
}
