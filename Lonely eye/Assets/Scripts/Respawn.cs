using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	public Transform player;
	public Transform spawnPoint;
	public Rigidbody2D rb;

	void start()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		player.transform.position = spawnPoint.transform.position;
		rb.velocity = Vector3.zero;
	}

}
