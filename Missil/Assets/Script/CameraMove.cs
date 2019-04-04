using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	public float speed = 0.15f;
	private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag ("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target) {		
			transform.position = Vector3.Lerp (transform.position, target.position, speed) + new Vector3(0,0,target.position.z-40);
		}
    }
}
