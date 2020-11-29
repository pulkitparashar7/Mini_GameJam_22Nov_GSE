using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineDispenser : MonoBehaviour
{
	[SerializeField]
	uint AmmoCount = 5;

	[SerializeField]
	GameObject MedicineBulletType = null;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
	}

	public void RequestAmmo(Gun gun)
	{
		if (gun == null)
		{
			return;
		}
		if (this.MedicineBulletType == null)
		{
			return;
		}
		gun.ReceiveAmmo(this.MedicineBulletType, this.AmmoCount);
	}

	void OnTriggerEnter2D(Collider2D hit)
    {
		GameObject otherObj = hit.gameObject;
		Gun gun = otherObj.GetComponent<Gun>();
		if(gun)
        {
			gun.OnNearDispenser(this);
        }
    }

	void OnTriggerExit2D(Collider2D other)
    {
		GameObject otherObj = other.gameObject;
		Gun gun = otherObj.GetComponent<Gun>();
		if (gun)
		{
			gun.OnLeftDispenser();
		}
	}
}
