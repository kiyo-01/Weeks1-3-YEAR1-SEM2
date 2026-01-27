using UnityEngine;

public class Sway : MonoBehaviour
{
    public Transform start;
    public Transform end;
    bool oneWay;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //reusing ball logic because it works
        //using empty game objects to track when it should move back

        if (oneWay)
        {
            t += Time.deltaTime;
            if (t >= 1) oneWay = false; 
        }
        else
        {
            t -= Time.deltaTime;
            if (t <= 0) oneWay = true;
        }

        //using just vector2.lerp made the z value keep going to 0 as a default
        //so I fiddled around with it and this seems to work

        Vector2 newPos = Vector2.Lerp(start.position, end.position, t); //standard lerp, isolated into a vector

        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z); //translating new vector info into transform
    }
}
