using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Flower : MonoBehaviour
{
    public float lerpTime;
    public float interpolation;
    public AnimationCurve curve;
    bool triggered = false;
    public float flowers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (triggered == true)
        {
            interpolation = curve.Evaluate(lerpTime);
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, interpolation);
            if (transform.localScale.z < 0.1f)
            {
                flowers = PlayerPrefs.GetFloat("Flowers", 0);
                flowers += 3;
                PlayerPrefs.SetFloat("Flowers", flowers);
                Destroy(gameObject);
            }
            lerpTime += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }
}
