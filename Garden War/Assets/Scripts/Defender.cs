using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    private StarDisplay starDisplay;

    void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }

    public void AddStars(int amount)
    {
        //print(amount + " stars added to display");
        starDisplay.AddStars(amount);
    }
}
