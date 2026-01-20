using UnityEngine;

public class RapidColourChange : MonoBehaviour
{
    public SpriteRenderer poopoo;
    public Color color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        poopoo.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        poopoo.color = Random.ColorHSV();
    }
}
