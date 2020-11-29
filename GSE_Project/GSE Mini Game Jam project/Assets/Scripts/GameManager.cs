using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Canvas GameCanvas;
    public Canvas EndCanvas;
    public Text WinText;
    public void Awake()
    {
        instance = this;
    }
    private void OnEnable()
    {
        GameCanvas.gameObject.SetActive(true);
        EndCanvas.gameObject.SetActive(false);
    }
    
    public void ShowEndScreen(string message)
    {
        WinText.text = message; 
        GameCanvas.gameObject.SetActive(false);
        EndCanvas.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
