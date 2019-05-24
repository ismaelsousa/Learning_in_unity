using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour{	
	private float time = 20f;//when instantiate new object wait x secund
	public GameObject missele;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine("spawns");
    }
	
	IEnumerator spawns(){       
		while(true){			
			if(time >= 5f){
				time -= 0.01f;
			}		
			yield return new WaitForSeconds(Random.Range(5f,time));	
			Instantiate(missele, transform.position, transform.rotation);	
		}
    }
    
}
