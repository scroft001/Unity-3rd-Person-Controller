﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour {

	public float Speed;

	
	// Update is called once per frame
	void Update () {
		PlayerMovement ();
	}

	void PlayerMovement(){
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		Vector3 playerMovement = new Vector3 (hor, 0f, ver) * Speed * Time.deltaTime;
		transform.Translate (playerMovement, Space.Self);
	}
}
