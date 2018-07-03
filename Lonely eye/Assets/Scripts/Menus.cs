using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene ("StartingText");
	}

	public void BeginGame()
	{
		SceneManager.LoadScene ("Game");
	}


	public void QuitGame()
	{
		Debug.Log ("Quit");
		Application.Quit();
	}

}
