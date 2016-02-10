using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


    public void PlayGame()
    {
        Application.LoadLevel(1); //play game
    }


    public void QuitGame()
    {
        Application.Quit(); //quit game
    }

}
