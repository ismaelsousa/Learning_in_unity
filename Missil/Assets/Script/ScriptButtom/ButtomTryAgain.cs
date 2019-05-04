using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtomTryAgain : MonoBehaviour
{
    public void loadGameAgain(){
        SceneManager.LoadScene("Game");
    }
    public void loadGame(){
        SceneManager.LoadScene("Game");
    }
}

