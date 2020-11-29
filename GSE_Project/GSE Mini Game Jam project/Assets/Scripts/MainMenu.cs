using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Sprite[] Kurzes;
    public Button sunButton;

    public AudioSource[] KurzSpeeches;

    private bool cooldown = false;
    private bool fade = false;

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

            sunButton.image.sprite = Kurzes[Random.Range(0, Kurzes.Length)];

            int randomSpeech = Random.Range(0, KurzSpeeches.Length);
            KurzSpeeches[randomSpeech].PlayOneShot(KurzSpeeches[randomSpeech].clip, 1f);

            Debug.Log("rnd speech:" + randomSpeech);

            Invoke("ResetCooldown", 5.0f);
            Invoke("FadeOutKurz", 2.0f);
        }
    }

    void FadeOutKurz()
    {
        fade = true;
    }

    void ResetCooldown()
    {
        var tempColor = sunButton.image.color;
        tempColor.a = 0f;
        sunButton.image.color = tempColor;
        cooldown = false;
    }

    private void Update()
    {
        if(fade)    // fade out Kurz
        {
            var tempColor = sunButton.image.color;
            tempColor.a -= 0.5f * Time.deltaTime;
            sunButton.image.color = tempColor;
            if (tempColor.a <= 0)
                fade = false;
        }
    }
}
