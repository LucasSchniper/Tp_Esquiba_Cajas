using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Text timerText;

    public TextMeshProUGUI timerTextMeshPro;
    float tiempo;

    void Update()
    {
        if (Time.timeScale == 0) return;
        tiempo += Time.deltaTime;
        timerTextMeshPro.text = "Tiempo: " + tiempo.ToString("F2");
    }
}
