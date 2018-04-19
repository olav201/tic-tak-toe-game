using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

    public void DoQuit()
    {
        Debug.Log("Has Quit Game");
        Application.Quit();
    }
}
