﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float fireRate = 0;
    public float Damage = 10;
    public LayerMask whatToHit;
    public Transform BulletTrailPrefab;

    float timeToFire = 0f;
    Transform firePoint;
        

	// Use this for initialization
	void Awake ()
    {
        firePoint = transform.FindChild ("FirePoint");	
        if (firePoint == null)
        {
            Debug.LogError("No firepoint");
        }
	}
	
	// Update is called once per frame
    void Update(){
        if(fireRate == 0){
            if (Input.GetKeyDown(KeyCode.Q)){
                Shoot();
            }
        }

        else{
            if (Input.GetKey(KeyCode.Q) && Time.time > timeToFire){
                timeToFire = Time.time + 1/fireRate;
                Shoot();
            }
        }
    }

    void Shoot(){
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);
        Effect();
        Debug.DrawLine(firePointPosition, (mousePosition-firePointPosition) *100, Color.cyan);
        if (hit.collider != null){
            Debug.DrawLine(firePointPosition, hit.point, Color.red);
            Debug.Log(" We hit" + hit.collider.name + " and dealt" + Damage + "damage.");
        }
    }

    void Effect(){
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);
    }
}
