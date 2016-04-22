using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

   private float playerScore = 0;
    private float highScore = 0;


    public GUISkin mySkin; //reference to GUISkin
  
	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime/2;
        highScore = PlayerPrefs.GetInt("HighScore");

    }


    public void IncreaseScore(int amount)
    {
        playerScore += amount;
        
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Confidence", (int)(playerScore));
        
        if ((int)playerScore >= (int)highScore)
        {
            PlayerPrefs.SetInt("HighScore", (int)(playerScore));
        }


    }

    void OnGUI()
    {
   	GUI.skin = mySkin;
    	var mystyle = new GUIStyle();
    	mystyle.normal.textColor = GUI.skin.label.normal.textColor;
    	mystyle.fontSize = 40; //font size
        GUI.Label(new Rect(20, 20, 1000, 60), "Positivty: " + (int)(playerScore), mystyle);
        GUI.Label(new Rect(20, 60, 1000, 60), "HighScore: " + (int)highScore, mystyle);
    }

}
