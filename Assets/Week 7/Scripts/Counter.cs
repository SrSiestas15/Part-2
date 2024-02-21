using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    TextMeshProUGUI counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "Score: " + Controller.score;
    }
}
