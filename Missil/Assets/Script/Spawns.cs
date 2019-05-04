using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour{	
	public int time = 2;//when instantiate new object wait x secund
	public GameObject missele;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine("spawns");
    }
	
	IEnumerator spawns(){       
		while(true){			
			yield return new WaitForSeconds(Random.Range(4.0f, 20.0f));	
			Instantiate(missele, transform.position, transform.rotation);	
		}
    }
    
}
