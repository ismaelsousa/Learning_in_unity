using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float speed = 0.4f;

    public Rigidbody2D rb;
    public Transform tf;

    public Vector2 movement;
    float directionY;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
        directionY = Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(1f, directionY );
    }

    void FixedUpdate()
    {
        movePlayer(movement);
    }

    void movePlayer(Vector2 direction)
    {
        rb.velocity = direction * speed;
       
        //se sair da tela se destroi
        if(tf.position.x > 15f){
             Debug.Log(tf.position.x);
            Destroy(gameObject);
        }
    }
}
