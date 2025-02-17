using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Slider chargeSlider;
    float charge;
    public float maxCharge = 1;
    Vector2 direction;
    public static float score = 0;
    public static SoccerPlayer selectedPlayer { get; private set; }
    public static void SetSelectedPlayer(SoccerPlayer player)
    {
        if(selectedPlayer != null)
        {
            selectedPlayer.Selected(false);
        }
        player.Selected(true);
        selectedPlayer = player;
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            selectedPlayer.Move(direction);
            direction = Vector2.zero;
            charge = 0;
            chargeSlider.value = charge;
        }
    }
    private void Update()
    {
        if (selectedPlayer == null) return;

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            charge = 0;
            Mathf.Clamp(charge, 0, maxCharge);
            direction = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            charge += Time.deltaTime;
            chargeSlider.value = charge;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - selectedPlayer.transform.position).normalized * charge;
        }
    }
}
