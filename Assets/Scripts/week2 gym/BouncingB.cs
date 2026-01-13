using UnityEngine;

public class BouncingB : MonoBehaviour
{
    public float speed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newPosition = transform.position;

        newPosition.x += speed;

        transform.position = newPosition;

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPosition.x >= Screen.width | screenPosition.x <= 0)
        {
            speed *= -1;

        }


    }
}
