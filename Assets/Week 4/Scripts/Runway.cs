using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runway : MonoBehaviour
{
    public Transform planePrefab;
    BoxCollider2D BoxCollider2D;
    bool landing = false;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        landing = true;
    }

}
