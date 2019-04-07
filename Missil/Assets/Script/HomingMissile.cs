using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HomingMissile : MonoBehaviour
{

    public Transform target;//alvo
    private Rigidbody2D rb;
    public int speed = 5;
	public int rotateSpeed = 200;
	public GameObject explosionEffect;
	
   

    void Start(){
		target =  GameObject.FindWithTag("Player").transform;		
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate(){
		Vector2 direction = (Vector2)target.position - rb.position;
		direction.Normalize();
		float rotateAmount = Vector3.Cross(direction, transform.up).z;
		rb.angularVelocity = -rotateAmount * rotateSpeed;
        rb.velocity = transform.up *speed;
    }
	
	void OnTriggerEnter2D(){
		Instantiate(explosionEffect, transform.position, transform.rotation);	
		Destroy(gameObject);						
	}

	
	
	
	
}
