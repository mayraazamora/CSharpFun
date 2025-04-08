using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = startPos + new Vector3(offset, 0, 0);
    }
}