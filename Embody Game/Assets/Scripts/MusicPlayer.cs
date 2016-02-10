using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject); //music from main menu keeps playing instead of being destroyed
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
