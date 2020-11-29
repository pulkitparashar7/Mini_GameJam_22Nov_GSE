using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineBullet : MonoBehaviour
{
    [SerializeField]
    float BulletSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeBullet(Transform trans)
    {
        this.transform.SetParent(trans);
        this.GetComponent<Rigidbody2D>().velocity = trans.right * this.BulletSpeed;
    }
}
