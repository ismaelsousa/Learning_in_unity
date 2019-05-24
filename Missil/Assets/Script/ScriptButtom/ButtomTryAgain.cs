using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtomTryAgain : MonoBehaviour
{
    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Load")
        {
            Debug.Log("sou o load");
            StartCoroutine("wait");
        }
    }
    public void loadGameAgain()
    {
        SceneManager.LoadScene("Load");
    }
    public void loadGame()
    {
        SceneManager.LoadScene("Load");
    }

    IEnumerator wait()
    {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("Game");
        
    }

}

