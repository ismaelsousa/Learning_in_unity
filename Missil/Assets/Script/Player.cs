using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float axis;
	public float axisVertical;
	public float speed = 0.4f;
	public Joystick joystick;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		//axis = Input.GetAxisRaw("Horizontal") * speed;
		axis = joystick.Horizontal;
		axisVertical = joystick.Vertical;
		if(axis > 0){
			//Debug.Log("----------------");
			//Debug.Log("direita");
			//Debug.Log(axis);
			gameObject.transform.position = new Vector3(transform.position.x+speed, transform.position.y,transform.position.z);
		}
		if(axis < 0){
			//Debug.Log("----------------");
			//Debug.Log("direita");
			//Debug.Log(axis);
			gameObject.transform.position = new Vector3(transform.position.x-speed, transform.position.y,transform.position.z);
		}
		if(axisVertical > 0.2f){
			//Debug.Log("----------------");
			//Debug.Log("cima");
			//Debug.Log(axisVertical);
			//Debug.Log(axisVertical);
			gameObject.transform.position = new Vector3(transform.position.x, transform.position.y+speed,transform.position.z);
			
		}
		if(axisVertical < -0.2f){
			//Debug.Log("----------------");
			//Debug.Log("baixo");
			//Debug.Log(axisVertical);
			//Debug.Log(axisVertical);
			gameObject.transform.position = new Vector3(transform.position.x, transform.position.y-speed,transform.position.z);
		}
        
    }
}
