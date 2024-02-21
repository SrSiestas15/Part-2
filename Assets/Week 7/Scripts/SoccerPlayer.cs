using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color selectedColour;
    public Color unselectedColour;
    bool selected = false;
    bool clickingOnSelf = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        Selected(true);
    }
}
