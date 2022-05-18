using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private Text TimeText;

    private void Start()
    {
        float sessionTime = Time.realtimeSinceStartup - PlayerPrefs.GetFloat("SessionTime");
        int MM = Mathf.FloorToInt(sessionTime / 60.0f);
        int SS = Mathf.FloorToInt(sessionTime % 60f);
        TimeText.text = "Your total time - " + MM.ToString("00") + ":" + SS.ToString("00");    
    }

    public void Quit()
    {
        Application.Quit();
    }
}
