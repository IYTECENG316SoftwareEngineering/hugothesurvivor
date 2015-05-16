using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class item_pickup : MonoBehaviour {

	public enum items
	{
		coin=0,
		money=1
	};
	public items item=items.coin;
	public Transform coinParticle;
	static int coin=0;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "body") 
		{
			print("girdi");
			Instantiate(coinParticle,transform.position,transform.rotation);
			ApplyPickup();
			Destroy(this.gameObject);
		}
	}
	void Start () {
	
	}
	void ApplyPickup()
	{
		coin+=1;
		print (coin);
		GameObject coinText = GameObject.FindWithTag ("coinText");
		coinText.GetComponent<Text> ().text="Coin: "+coin;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
