﻿using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

    float playerScore = 0;
    
   
  
	
	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime;  
	}


    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Confidence", (int)(playerScore*100));
    }

    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 200, 60), "Confidence: " + (int)(playerScore * 100));
    }

}
