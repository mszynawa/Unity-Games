using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    private void Start()
    {
        if (autoLoadNextLevelAfter <= 0) {
            Debug.Log("Level auto load disabled, use a positive number is seconds.");
        } else {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
        
    }

    public void LoadLevel(string name)
    {
        Debug.Log("New Level Load: " + name);
        Application.LoadLevel(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested.");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
