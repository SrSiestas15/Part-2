using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Screen169 : MonoBehaviour
{
    CanvasScaler scaler;
    private void Start()
    {
        scaler = GetComponent<CanvasScaler>();
    }
    public void changeResolution169()
    {
        scaler.referenceResolution = new Vector2 (1600, 900);
    }

    public void changeResolutionHD()
    {
        scaler.referenceResolution = new Vector2(1920, 1080);
    }
}
