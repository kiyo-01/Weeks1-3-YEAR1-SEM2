using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //used practically the same thing as yours, if aint broke dont fix it!
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        transform.position = mouse;
    }
}
