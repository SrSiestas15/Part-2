using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 150f;
    float timer = 0;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessageUpwards("TakeDamage", 1, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
