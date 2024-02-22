using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{
    public Rigidbody2D keeperRb;
    Transform Transform;

    Vector2 direction;
    Vector2 normalized;
    float distance;
    public float offGoal = 10;
    float chosenDist;

    void Start()
    {
        //Controller.selectedPlayer.transform.position
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.selectedPlayer != null)
        {
            direction =  (Controller.selectedPlayer.transform.position - gameObject.transform.position);
            distance = direction.magnitude;
            direction = direction.normalized;
            keeperRb.transform.position = direction;
        }
    }
}
