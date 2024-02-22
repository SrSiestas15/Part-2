using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{
    public Rigidbody2D keeperRb;
    public Transform realGoal;

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
            normalized = direction.normalized;
            chosenDist = Vector2.Distance(realGoal.position, Controller.selectedPlayer.transform.position);
            if (chosenDist < 6)
            {
                keeperRb.transform.position = normalized * distance / offGoal;
                Debug.Log("GRAGGHHGHG");
            } else {
                keeperRb.transform.position = normalized * distance / offGoal*.3f;
                Debug.Log("shit");
            }
        }
    }
}
