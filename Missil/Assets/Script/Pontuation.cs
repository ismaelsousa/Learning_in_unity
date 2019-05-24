using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pontuation : MonoBehaviour
{


    public static UnityEngine.UI.Text text;
    public static int pontuation;
    private void Awake()
    {
        text = this.GetComponent<UnityEngine.UI.Text>();
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        if (scene.name == "GameOver")
        {
            int pontos = PlayerPrefs.GetInt("pontuation");
            text.text = pontos.ToString();

        }else if(scene.name == "Game")
        {
            PlayerPrefs.SetInt("pontuation", 0);
        }

    }
    private void Update()
    {

    }
    public static void atualizaPontuation()
    {
        pontuation++;
        text.text = pontuation.ToString();
        PlayerPrefs.SetInt("pontuation", pontuation);
    }
}
