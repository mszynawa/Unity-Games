﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    public enum Status { SUCCESS, FAILURE };

    private Text starText;
    private int stars = 100;

    void Start() {
        starText = GetComponent<Text>();
        //stars = 100;
        UpdateDisplay();
    }

    public void AddStars(int amount) { 
        stars += amount;
        UpdateDisplay();
    }

    public Status UseStars(int amount) {
        if (stars >= amount) {
            stars -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        } else {
            return Status.FAILURE;
        }            
    }

    private void UpdateDisplay() {
        starText.text = stars.ToString();
    }
}
