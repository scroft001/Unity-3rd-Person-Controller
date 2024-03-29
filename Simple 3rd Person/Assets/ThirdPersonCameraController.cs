﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour {

	public float RotationSpeed = 1;
	public Transform Target;
	public Transform Player;
	float mouseX;
	float mouseY;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void LateUpdate(){
		CamControl ();
	}

	void CamControl(){
		mouseX += Input.GetAxis ("Mouse X") * RotationSpeed;
		mouseY -= Input.GetAxis ("Mouse Y") * RotationSpeed;
		mouseY = Mathf.Clamp (mouseY, -35, 60);

		transform.LookAt (Target);

		Target.rotation = Quaternion.Euler (mouseY, mouseX, 0);
		Player.rotation = Quaternion.Euler (0, mouseX, 0);
	}

}
