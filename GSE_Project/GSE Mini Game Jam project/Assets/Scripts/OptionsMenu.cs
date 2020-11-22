using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void setVolume(float volume)
    {
        Debug.Log("new volume " + volume);
    }

    public void setFullscreen(bool isFullscreen)
    {
        Debug.Log("Fullscreen: " + isFullscreen);
        Screen.fullScreen = isFullscreen;
    }
}
