using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Menu : MonoBehaviour
{
    public UnityEngine.UI.Button BnStart;

    void Start()
    {
        BnStart.onClick.AddListener(StartGameSolo);
    }

    // Update is called once per frame
    void StartGameSolo()
	{

	}
}
