using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI worldText;
    public TextMeshProUGUI cointText;
    public TextMeshProUGUI marioText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frrame
    void Update()
    { 
        int intTime =  400 -  (int) Time.realtimeSinceStartup;
        string timeStr = $"Time \n {intTime}";
        timerText.text = timeStr;
        string worldStr = $"World \n 1-1";
        worldText.text = worldStr;

        string coinStr = $" - ";
        cointText.text = coinStr;
        string marioStr = $"Mario \n (intPoints)";
        marioText.text = marioStr;

    }
}
