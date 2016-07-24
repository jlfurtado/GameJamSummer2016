﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadSceneOnButtonPush : MonoBehaviour {

    [SerializeField] private string nextLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.anyKey)
        {
            SceneManager.LoadScene(nextLevel);
        }
	}
}
