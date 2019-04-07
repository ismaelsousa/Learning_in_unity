using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    public GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine("factory");
    }

   

    IEnumerator factory(){
        while(true){
			GameObject clone = Instantiate(asteroid, transform.position, transform.rotation);	
            clone.transform.position = new Vector2(clone.transform.position.x,Random.Range(-5,14));
			yield return new WaitForSeconds(8);		
		}
    }
}
