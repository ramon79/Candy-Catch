using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public bool canMove = true;

	//[SerializeField]	
	//float maxPos;

	[SerializeField]
	float moveSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(canMove)
		{
			Move();

		}
		
	}

	private void Move()
	{
		float inputX = Input.GetAxis("Horizontal");

		transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
		
		// float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
		float xPos = Mathf.Clamp(transform.position.x, -65f, -50f);

		transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

	}
}
