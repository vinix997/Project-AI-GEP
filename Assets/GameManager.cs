using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text scoreText;
	 private float timeLimit;
	public Text finalScoreText;
	public Text loseScoreText;
	 public Text timerText;
	public GameObject text;
	public static GameManager instance;
	public int score;
	public GameObject loseScreen;
	public GameObject gameOver;
	// Use this for initialization
	void Start () {
		instance = this;
		StartCoundownTimer();
	}
	
	// Update is called once per frame
	void Update () {
		TimeUp();
		UpdateHighscore();
		 UpdateScore();
		 TimeDanger();
	}
	void UpdateHighscore()
	{
		if(PlayerPrefs.GetInt("Stage1 score",0) <= score)
	 	PlayerPrefs.SetInt("Stage1 score",score);
	}
	void UpdateScore()
	{
		scoreText.text = "Score : " + score.ToString();
		finalScoreText.text = "Score : " + score.ToString();
		loseScoreText.text = "Score : " + score.ToString();
	}
	void TimeUp()
	{
		if(timeLimit<=0)
		{
			gameOver.SetActive(true);
			text.SetActive(false);
			Time.timeScale = 0;
		}
	}
	void TimeDanger()
	{
		if(timeLimit<=60)
		{
			timerText.color = Color.red;
		}
	}
	public void LoseScreen()
	{
		loseScreen.SetActive(true);
		Time.timeScale = 0;
		text.SetActive(false);
	}
	

 
 
     
 
 
 void StartCoundownTimer()
 {
     if (timerText != null)
     {
         timeLimit = 300;
         timerText.text = "Time Left: 05:00";
         InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
     }
 }
 
 void UpdateTimer()
 {
     if (timerText != null)
     {
         timeLimit -= Time.deltaTime;
         string minutes = Mathf.Floor(timeLimit / 60).ToString("00");
         string seconds = (timeLimit % 60).ToString("00");
         timerText.text = "Time Left: " + minutes + ":" + seconds;
		
     }
 
 }
}
