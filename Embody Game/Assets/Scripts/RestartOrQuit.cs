using UnityEngine;
using System.Collections;

public class RestartOrQuit : MonoBehaviour {


    public void RestartGame()
    {
        Application.LoadLevel(1); //restart game
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
