using UnityEngine;
using System.Collections;

public class aniSprite : MonoBehaviour {

	void Update () {
		
		//aniSprite (columnSize,rowSize,columnFrameStart,rowFrameStart,totalFrames,framePerSecond);
		
		
	}
	public void AniSprite(int columnSize,int rowSize,int columnFrameStart,int rowFrameStart,int totalFrames,float framePerSecond)
	{
		int index = Mathf.CeilToInt (Time.time*framePerSecond); //index float olursa kayar hareket etmez!!
		index = index % totalFrames;
		Vector2 size = new Vector2 (1.0F/columnSize,1.0F/rowSize);
		
		int u = index % columnSize;
		int v = index / columnSize;
		Vector2 offset = new Vector2 ((u+columnFrameStart)*size.x,(1-size.y)-(v+rowFrameStart)*size.y);
		renderer.material.mainTextureOffset= offset;
		renderer.material.mainTextureScale=size;
		
		//renderer.material.SetTextureOffset ("_BumpMap",offset);
		//renderer.material.SetTextureScale ("_BumpMap",size);
	}
}
