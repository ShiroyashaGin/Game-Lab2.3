﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public List<Object> levels;

	void Awake () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
