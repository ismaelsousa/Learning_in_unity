using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static Sounds instancia;

    private void Awake() {
        if (instancia == null) {
			instancia = this;
			Debug.Log ("fui criado");
		} else {
			Destroy (instancia);
		}
    } 
    //som
    public AudioSource audioControllerMissile;  
    
    //audios para serem tocados
    public AudioClip soundBomb;
    
     public void playSoundBomb(){
        audioControllerMissile.PlayOneShot(soundBomb);
    }

}
