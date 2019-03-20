using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissil : MonoBehaviour
{
	public Transform target;//alvo
    private Rigidbody2D rb;
    public int speed = 5;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {  
		//Vector2 direction = (Vector2)target.position - rb.position;
		//direction.Normalize();
		//float rotateAmount = Vector3.Cross(direction, transform.up).z;
		//rb.angularVelocity = rotateAmount * 2;
        //rb.velocity = transform.up *speed;	 
    }
}
