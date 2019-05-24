using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 0.4f;

	public Rigidbody2D rb;

	public Transform tf;

	public Vector2 movement;
	public Joystick joystick;
	
    // Start is called before the first frame update
    void Start()
    {
		tf = this.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
			movement = new Vector2(joystick.Horizontal,joystick.Vertical);
			if(tf.position.x < -11){
				tf.position = new Vector3(11,tf.position.y,tf.position.z);
			}else if (tf.position.x > 11){
				tf.position = new Vector3(-11,tf.position.y,tf.position.z);
			}else if (tf.position.y < -6){
				tf.position = new Vector3(tf.position.x,6,tf.position.z);
			}else if (tf.position.y > 6){
				tf.position = new Vector3(tf.position.x,-6,tf.position.z);
			}
	
    }

		 void FixedUpdate() {
			movePlayer(movement);
		}

		void movePlayer(Vector2 direction){
			rb.velocity = direction * speed;
		}
}
