using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType
{
    Green = 0,
    Blue = 1,
    Red = 2
}
public class MedicineBullet : MonoBehaviour
{
    [SerializeField]
    float BulletSpeed = 100;

    [SerializeField]
    public BulletType BulletType;
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
        transform.localScale = Vector3.one;
        this.GetComponent<Rigidbody2D>().velocity = trans.right * this.BulletSpeed;
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        GameObject otherObj = hit.gameObject;
        Enemy patient = otherObj.GetComponent<Enemy>();
        if (patient)
        {
            Debug.Log("BUllet overlap with patient");
            bool actuallyHitSomething = patient.NotifyHitByBullet(this);
            if(actuallyHitSomething)
            {          
                Destroy(this.gameObject);
            }
        }
    }
}
