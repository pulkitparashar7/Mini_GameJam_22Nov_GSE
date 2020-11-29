using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.LogError(collision.gameObject.tag);
            GameManager.instance.ShowEndScreen("You Lost!! You got CORONA!!");
        }
        
    }
   
}
