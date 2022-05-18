using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    [SerializeField] private Text TimeText;

    private void Update()
    {
        float sessionTime = Time.realtimeSinceStartup - PlayerPrefs.GetFloat("SessionTime");
        int MM = Mathf.FloorToInt(sessionTime / 60.0f);
        int SS = Mathf.FloorToInt(sessionTime % 60f);
        TimeText.text = "Time: " + MM.ToString("00") + ":" + SS.ToString("00");
    }
}
