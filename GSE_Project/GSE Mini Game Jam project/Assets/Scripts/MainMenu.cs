using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Sprite[] Kurzes;
    public Button sunButton;

    private bool cooldown = false;

    public void PlayGame()
    {
        Debug.Log("start game");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }

    public void PressSunButton()
    {
        Debug.Log("sun pressed");
        if (cooldown == false)
        {
            cooldown = true;

            var tempColor = sunButton.image.color;
            tempColor.a = 1f;
            sunButton.image.color = tempColor;

            sunButton.image.sprite = Kurzes[Random.Range(0, Kurzes.Length-1)];
            Invoke("ResetCooldown", 2.0f);
        }
    }

    void ResetCooldown()
    {
        var tempColor = sunButton.image.color;
        tempColor.a = 0f;
        sunButton.image.color = tempColor;
        cooldown = false;
    }

}
