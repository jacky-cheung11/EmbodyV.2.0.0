using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

    int score = 0;
    public GUISkin gameOver;
	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("Confidence");
	}

    void OnGUI()
    {
    GUI.skin = gameOver;
		var mystyle = new GUIStyle();
    	mystyle.normal.textColor = GUI.skin.label.normal.textColor;
    	mystyle.fontSize = 40; //font size
        GUI.Label (new Rect(Screen.width / 2 - 170, 200, 320, 120), "Confidence: " + score, mystyle);
    }

}
