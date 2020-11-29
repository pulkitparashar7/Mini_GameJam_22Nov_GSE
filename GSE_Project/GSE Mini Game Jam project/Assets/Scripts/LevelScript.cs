using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    [SerializeField]
    Text TimerText;
    [SerializeField]
    float LevelDuration = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.LevelDuration -= Time.deltaTime;
        this.UpdateTimerText();
        if(this.LevelDuration <= 0)
        {
            this.LevelDuration = 0f;
        }
    }

    void UpdateTimerText()
    {
        this.TimerText.text = this.LevelDuration.ToString("F1");
    }
}
