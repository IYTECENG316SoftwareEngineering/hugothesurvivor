using UnityEngine;
using System.Collections;

public class coinRotate : MonoBehaviour {

	public float rotateCoinSpeed=20.0F;
	void Update () {
		aniSprite aniPlay=GetComponent<aniSprite>();
		aniPlay.AniSprite (16,2,0,0,21,rotateCoinSpeed);
	}
}
