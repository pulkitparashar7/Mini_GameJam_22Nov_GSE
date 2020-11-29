using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Movement Movement;
    // Start is called before the first frame update
    void Start()
    {
        this.Movement = this.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            this.Movement.ApplyMovement(new Vector2(0, 1));
        }
        else if (Input.GetKey("s"))
        {
            this.Movement.ApplyMovement(new Vector2(0, -1));
        }
        else
        {
            this.Movement.ApplyMovement(new Vector2(0, 0));
        }
    }
}
