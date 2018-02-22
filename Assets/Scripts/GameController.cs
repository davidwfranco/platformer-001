using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public static GameController instance;
	public Camera cam;
    public Vector2 upperCorner;
    public Vector2 targeCamtWidth;
    public float maxWidth;
    public float maxHeigth;
    public bool gameOver;
    public GameObject gameLooseText;
    public GameObject gameWinText;
    private int score;
    public Text scoreText;
    private int lives;
    public Text livesText;

	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        if (cam == null)
        {
            cam = Camera.main;
        }
        
        upperCorner = new Vector2(Screen.width, Screen.height);
        targeCamtWidth = GameController.instance.cam.ScreenToWorldPoint(upperCorner);
        maxWidth = targeCamtWidth.x;
        maxHeigth = targeCamtWidth.y;
        
		lives = 3;

		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
