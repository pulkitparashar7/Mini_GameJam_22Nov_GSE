using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    uint AmmoCount;

    [SerializeField]
    MedicineDispenser NearbyDispenser;

    [SerializeField]
    GameObject EquippedMedicine;

    [SerializeField]
    float BulletSpeed;

    [SerializeField]
    Transform Doc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.TryToReload();
        }
        if (Input.GetMouseButtonDown(0))
        {
            this.Fire();
        }
    }
    void Fire()
    {
        if (this.AmmoCount <= 0)
        {
            return;
        }
        if (this.EquippedMedicine == null)
        {
            return;
        }
        this.AmmoCount--;
        GameObject medThrow = Instantiate(this.EquippedMedicine, this.Doc.position, this.Doc.rotation);
        MedicineBullet bulletComp = medThrow.GetComponent<MedicineBullet>();
        if(bulletComp)
        {
            bulletComp.InitializeBullet(this.Doc);
        }
    }

    public void TryToReload()
    {
        if(this.NearbyDispenser == null)
        {
            return;
        }
        this.NearbyDispenser.RequestAmmo(this);
    }

    public void ReceiveAmmo(GameObject ammoType, uint ammoCount)
    {
        this.EquippedMedicine = ammoType;
        if (this.EquippedMedicine == null)
        {
            this.AmmoCount = 0;
            return;
        }
        this.AmmoCount = ammoCount;
    }

    public void OnNearDispenser(MedicineDispenser dispenser)
    {
        this.NearbyDispenser = dispenser;
    }

    public void OnLeftDispenser()
    {
        this.NearbyDispenser = null;
    }
}
