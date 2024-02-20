using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picnic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("EnterPicnic", SendMessageOptions.DontRequireReceiver);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("ExitPicnic", SendMessageOptions.DontRequireReceiver);
    }
}
