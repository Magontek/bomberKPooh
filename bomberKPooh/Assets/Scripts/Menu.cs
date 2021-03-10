using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Menu : MonoBehaviour
{
    public UnityEngine.UI.Button bnStartSolo;
    public UnityEngine.UI.Button bnQuit;

    void Start()
    {
        bnStartSolo.onClick.AddListener(StartGameSolo);
        bnQuit.onClick.AddListener(QuitGame);
    }

    void StartGameSolo()
	{
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}

    void QuitGame()
	{
        Debug.Log("QUIT");
        Application.Quit();
    }
}
