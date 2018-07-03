using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public bool OnGround;
	private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () 
	{
		OnGround = true;
		rb2D = GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void Update () 
	{

		if (OnGround) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				rb2D.velocity = new Vector3 (4.5f, 6f, 0f);
				OnGround = false;
			}

		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		gameObject.CompareTag("Ground");
		OnGround = true;
	}






}
