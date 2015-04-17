using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	
	GameObject camera ;
	public float gravity=20.0F;
	public float moveSpeed=5.0F;
	public float moveLeftRight=12.0F;
	Vector3 movement=Vector3.zero;
	CharacterController controller;

	Vector3 start;
	Vector3 end;
	public float step = 5;

	public float jump=20.0F;
	GameObject lose;
	void Start () {
		camera=GameObject.FindWithTag("MainCamera");
		controller=GetComponent<CharacterController>();

		start = transform.position;
		end =new Vector3(transform.position.x-20,transform.position.y,transform.position.z);
		lose = GameObject.FindWithTag ("Lose");
		lose.SetActive (false);
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "killbox") 
		{
			lose.SetActive (true);
			StartCoroutine(Lose());
		}
	}
	IEnumerator Lose()
	{
		yield return new WaitForSeconds(2);
		Application.LoadLevel("screenMainMenu");
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 storedVectorCamera = camera.transform.position;
		storedVectorCamera.z = this.transform.position.z + 16;
		camera.transform.position = storedVectorCamera;
		Vector3 storedVectorMovement = this.transform.position;
		storedVectorMovement.z -= moveSpeed * Time.deltaTime;


		if (controller.isGrounded) 
		{
			if(Input.GetButtonDown("Jump"))
			{
				movement.y=jump;
			}
		}
		if (!controller.isGrounded) 
		{

			movement.y-=gravity*Time.deltaTime;

		}
		if (Input.GetButtonDown("a")) 
		{
			storedVectorMovement.x-=-1*moveLeftRight;
			//movement.x=moveLeftRight;
			//Vector3 target=new Vector3(transform.position.x-5,transform.position.y,transform.position.z);
			//storedVectorMovement = Vector3.MoveTowards(transform.position,target , step);
			//Vector3 movedir;
			//movedir = Vector3.Lerp(transform.position, end, 1.0F);		
			//transform.Translate(end*Time.deltaTime,Space.World);
		}
		if (Input.GetButtonDown("d")) 
		{
			storedVectorMovement.x-=moveLeftRight;
			//movement.x=-1*moveLeftRight;
		}
		this.transform.position = storedVectorMovement; // z eksen hareketi
		//transform.Translate (storedVectorMovement);
		controller.Move(movement*Time.deltaTime);		// yerçekimi
	}
}