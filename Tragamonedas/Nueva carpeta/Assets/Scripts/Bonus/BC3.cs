﻿using UnityEngine;
using System.Collections;

public class BC3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BC3");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
