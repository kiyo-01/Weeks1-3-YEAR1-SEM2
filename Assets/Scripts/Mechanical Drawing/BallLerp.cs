using UnityEngine;

public class BallLerp : MonoBehaviour
{
    public Transform player;
    public Transform opponent;
    public float t;
    public AnimationCurve explosive;
    bool oneWay = true;
    Vector3 initialSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (oneWay) //simple bool switch
        {
            t += Time.deltaTime;
            if (t >= 1) oneWay = false; //reach opponent, switch direction
        }
        else
        {
            t -= Time.deltaTime;
            if (t <= 0) oneWay = true; //reach player, switch direction
        }
        
        //set position as new values
        transform.position = Vector2.Lerp(player.position, opponent.position, explosive.Evaluate(t));
      
        //lerp localscale value simultaneously with movement
        transform.localScale = Vector3.Lerp(initialSize, initialSize * 0.25f, t);
    }
}
