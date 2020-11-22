using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;

    [SerializeField]
    GameObject medicine;
    [SerializeField]
    Transform doc;

    [SerializeField]
    GameObject med1;
    [SerializeField]
    GameObject med2;
    [SerializeField]
    GameObject med3;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0, speed * -1);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            clicked();
        }

    }

    void clicked()
    {
        GameObject medThrow = Instantiate(medicine, doc.position, doc.rotation);
        medThrow.transform.SetParent(doc);
        medThrow.GetComponent<Rigidbody2D>().velocity = doc.right * 100f;
    }

    
}
