using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Movement Movement;
    Gun MedicineGun;
    Animator DocAnimation;
    // Start is called before the first frame update
    void Start()
    {
        this.Movement = this.GetComponent<Movement>();
        MedicineGun = GetComponent<Gun>();
        DocAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MedicineGun.TryToReload();
        }
        if (Input.GetMouseButtonDown(0))
        {
            MedicineGun.Fire();
            DocAnimation.Play("DocShooting");
        }
        if (Input.GetKey("w"))
        {
            this.Movement.ApplyMovement(new Vector2(0, 1));
            DocAnimation.Play("DocMovingUp");
        }
        else if (Input.GetKey("s"))
        {
            this.Movement.ApplyMovement(new Vector2(0, -1));
            DocAnimation.Play("DocAnimation");
        }
        else
        {
            this.Movement.ApplyMovement(new Vector2(0, 0));
        }
    }
}
