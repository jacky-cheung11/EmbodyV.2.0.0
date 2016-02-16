﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

    int score = 0;
	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Confidence");
	}

    void OnGUI()
    {
        GUI.Label (new Rect(Screen.width / 2 - 40, 60, 160, 60), "Confidence: " + score);
    }

}
