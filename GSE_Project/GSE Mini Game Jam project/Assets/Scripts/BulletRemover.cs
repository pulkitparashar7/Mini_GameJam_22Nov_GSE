using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRemover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        GameObject otherObj = hit.gameObject;
        MedicineBullet bullet = otherObj.GetComponent<MedicineBullet>();
        if (bullet)
        {
            Destroy(bullet.gameObject);
        }
    }
}
