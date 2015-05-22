using UnityEngine;
using System.Collections;

public class sceneLoader : MonoBehaviour {

	public void LoadScene1()
	{
		Application.LoadLevel ("Scene1");
	}
	public void LoadInstructions()
	{
		Application.LoadLevel ("screenMainMenu");
	}
	public void Exit()
	{
		Application.Quit();
	}
}
