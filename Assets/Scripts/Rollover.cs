using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    public Rotate rotate;
    public SpriteRenderer duck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (duck.bounds.Contains(mousePos) == true)
        {
            rotate.speed = 0;
        }
        else 
        {
            rotate.speed = 100;
        }
    }
}
