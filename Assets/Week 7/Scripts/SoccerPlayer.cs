using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    public Color selectedColour;
    public Color unselectedColour;
    public float speed = 10f;
    bool selected = false;
    bool clickingOnSelf = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Selected(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Selected(bool selected)
    { 
        if (selected)
        {
            spriteRenderer.color = selectedColour;
        }
        else
        {
            spriteRenderer.color = unselectedColour;
        }
    }

    private void OnMouseDown()
    {
        Controller.SetSelectedPlayer(this);
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
