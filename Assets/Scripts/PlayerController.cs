using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rdb2d;
	private Vector2 rawPosition;
	private Vector2 targetPotision;
	private float targetWidth;
	private GameController gControl;
	public float moveSpeed;
	private float moveHDir;
	private bool onAir;

	// Use this for initialization
	void Start () {
		rdb2d = GetComponent<Rigidbody2D>();
		gControl = GameController.instance;
		onAir = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!gControl.gameOver)
		{
			moveHDir = Input.GetAxisRaw("Horizontal");
			rdb2d.velocity = new Vector2((moveSpeed * moveHDir), 0);

			if (Input.GetKeyDown(KeyCode.Space))
			{
				rdb2d.AddForce(new Vector2(0.0f, 2.0f));
				onAir = true;
			} else {
				onAir = false;
			}
		}	
	}
}
