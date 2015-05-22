using UnityEngine;
using System.Collections;
public class screenMainMenu : MonoBehaviour {
	
	int optimalHeight = 1024; //just an example
	int optimalWidth = 768;
	Vector2 screen;

	private Vector2 scale;
	TextMesh text;
	void Start () {

		
	}

	
	/*void OnGUI()
	{

		if(GUI.Button(new Rect(Screen.width*0.35F,Screen.height*0.4F,Screen.width*0.3F,Screen.height*0.1F),"<size="+Screen.height*0.05F+">Start Game</size>"))
		{

			Application.LoadLevel("Scene1");
		}
		if(GUI.Button(new Rect(Screen.width*0.35F,Screen.height*0.7F,Screen.width*0.3F,Screen.height*0.1F),"<size="+Screen.height*0.05F+">Credits</size>"))
		{
			Application.LoadLevel("screenMainMenu");
		}
		if(GUI.Button(new Rect(Screen.width*0.35F,Screen.height*0.55F,Screen.width*0.3F,Screen.height*0.1F),"<size="+Screen.height*0.05F+">Instructions</size>"))
		{
			Application.LoadLevel("screenMainMenu");
		}
		if(GUI.Button(new Rect(Screen.width*0.35F,Screen.height*0.85F,Screen.width*0.3F,Screen.height*0.1F),"<size="+Screen.height*0.05F+">Exit</size>"))
		{
			Application.Quit();
		}
		
		
		
		//GUI.EndGroup();
	}*/
	
}