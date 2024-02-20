using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FlowerText : MonoBehaviour
{
    TextMeshProUGUI flowerCount;
    float flowers;

    void Start()
    {
        flowerCount = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        flowers = PlayerPrefs.GetFloat("Flowers", 0);
        flowerCount.text = "Flowers: " + PlayerPrefs.GetFloat("Flowers", 0);
    }
}
