using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrier : MonoBehaviour {

    public GameObject player;
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = spawnPoint.transform.position;
    }
}
