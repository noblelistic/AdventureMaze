﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb2d;
	private int count;
	public Text countText;
	public Text winText;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		count = 0;
		winText.text = "";
		SetCountText ();


	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);

	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			Debug.Log(winText.text);
		}


	}

	void SetCountText()
	{
		countText.text = "Count:" + count.ToString ();
		if (count == 9)
		{
			winText.text = "YOU WIN!!";			
		} else if(count == 1)
		{
			winText.text = "Good Job";
		} else if(count == 2)
		{
			winText.text = "";
		} else if(count == 8)
		{
			winText.text = "You've Almost Won";
		}
	}



}