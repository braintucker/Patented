﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJumpItem : MonoBehaviour 
{
	GameObject go;
	Rigidbody2D rigi;
	bool hasItem = false;
	Vector3 character;
	Vector3 hover;


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag.Contains("Player")) 
		{
			hasItem = true;
			rigi = other.GetComponent<Rigidbody2D> ();
			other.GetComponent<CharacterControllerScripLevel2> ().hasItem = 1;
		}
	}

	private void Update()
	{
		if (hasItem) 
		{
			character = rigi.position;
			character.Set (character.x, character.y + 7, character.z);
			GetComponent<Transform> ().position = character;

		}
	}
}
