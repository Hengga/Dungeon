﻿using UnityEngine;
using System.Collections;

public class AnimTest : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.DownArrow)){
			anim.SetBool("Walk",true);
	}
}
}
