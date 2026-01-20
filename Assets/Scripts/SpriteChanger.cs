using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    //public Sprite[] barrels;
    public int randomNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite big dawg");
            //PickARandomColour();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }        
        }

        //NOT SPRITE RENDERER: spriteRenderer.sprite.bounds.Contains()
        //THIS: spriteRenderer.bounds.Contains()

        //get mouse pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the shape?
        if(spriteRenderer.bounds.Contains(mousePos) == true) 
        {
            //if yes, set the color with our col variable
            spriteRenderer.color = col;    
        }
        else
        {
            //if no, set color to white
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }
    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;

        //pick a random number
        randomNum = Random.Range(0, barrels.Count);
        //use that number to choose a sprite
        //assign that sprite to the sprite renderer 
        spriteRenderer.sprite = barrels[randomNum];

    }

}
