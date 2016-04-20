using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

    int score = 0;
    int highScore;
    public GUISkin gameOver;
	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Confidence");
        highScore = PlayerPrefs.GetInt("HighScore");
	}

    void OnGUI()
    {
    GUI.skin = gameOver;
		var mystyle = new GUIStyle();
    	mystyle.normal.textColor = GUI.skin.label.normal.textColor;
    	mystyle.fontSize = 40; //font size
        GUI.Label (new Rect(Screen.width / 2 - 170, 200, 320, 120), "Confidence: " + score, mystyle);
        GUI.Label(new Rect(Screen.width / 2 - 170, 100, 320, 120), "HighScore: " + score, mystyle);
    }

}
