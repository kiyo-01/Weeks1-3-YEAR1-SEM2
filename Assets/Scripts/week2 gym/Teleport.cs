using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Teleport : MonoBehaviour
{
    public float t;
    public Vector2 pos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;




        t += Time.deltaTime;
        if (t > 3)
        {
            pos.x = Random.Range(-9, 9);
            //pos.x = Random.Range(-Screen.width, Screen.width);
            pos.y = Random.Range(-4, 4);
            //pos.y = Random.Range(-Screen.height, Screen.height);

            t = 0;
        }

        transform.position = pos;

    }
}
