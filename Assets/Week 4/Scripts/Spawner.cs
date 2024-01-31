using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] planes;
    float loadingTimer = 0;
    Transform spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        loadingTimer += Time.deltaTime;
        if (loadingTimer >= 5)
        {
            transform.position = new Vector3(Random.Range(-5, 6), Random.Range(-5, 6), 0);
            transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 361)); ;
            Instantiate(planes[Random.Range(0, 4)],transform.position,transform.rotation);
            loadingTimer = 0;
        }
    }
}
