using UnityEngine;

public class CrowdJump : MonoBehaviour
{
    public float jumpHeight = 0.5f;
    public float speed = 2f;
    Vector3 startPos;
    float t = 0;
    bool goingUp = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //track the position where they started from on the floor
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //more reused script from BallLerp
        if (goingUp)
        {
            t += Time.deltaTime * speed; //was moving too fast originally
            if (t >= 1) goingUp = false;
        }
        else
        {
            t -= Time.deltaTime * speed;
            if (t <= 0) goingUp = true;
        }

        //create "peak" position
        Vector3 peakPos = new Vector3(startPos.x, startPos.y + jumpHeight, startPos.z);

        //lerp to move between floor and peak
        transform.position = Vector3.Lerp(startPos, peakPos, t);

    }
}
