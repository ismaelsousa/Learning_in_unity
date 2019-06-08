using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomingMissile : MonoBehaviour
{

    public Transform target;//alvo
    private Rigidbody2D rb;
    public int speed = 5;
    public int rotateSpeed = 200;
    public GameObject explosionEffect;





    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -rotateAmount * rotateSpeed;
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D outher)
    {
        if (outher.tag == "Player")
        {
        	Sounds.instancia.playSoundBomb();
            SceneManager.LoadSceneAsync("GameOver");
			
			Destroy(outher.gameObject);
			Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (outher.tag == "missile")
        {
            //atualiza um ponto a mais
            Pontuation.atualizaPontuation();
            Sounds.instancia.playSoundBomb();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            //atualiza um ponto a mais
            Pontuation.atualizaPontuation();
            //instance static from Sounds
            //audioControllerMissile.PlayOneShot(soundBomb);
            Sounds.instancia.playSoundBomb();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }






}
