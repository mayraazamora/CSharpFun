using UnityEngine;

public class ClickColorChange : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked!");
        sr.color = new Color(Random.value, Random.value, Random.value);
    }
}