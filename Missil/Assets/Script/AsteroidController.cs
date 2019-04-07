using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float speed = 0.4f;

	public Rigidbody2D rb;

	public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
         rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(1f,0f);
    }

     void FixedUpdate() {
			movePlayer(movement);
	}

		void movePlayer(Vector2 direction){
			rb.velocity = direction * speed;
		}
}
