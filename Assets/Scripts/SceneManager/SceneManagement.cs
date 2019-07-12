using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour {

	public GameObject optionPanel;
	public GameObject hsPanel;

	public GameObject mainPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		
	}
	public void Play()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Main");
	}
	public void Back()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Menu");
	}
	public void OpenOption()
	{
		optionPanel.SetActive(true);
		mainPanel.SetActive(false);
		hsPanel.SetActive(false);
	}
	public void OpenMain()
	{
		optionPanel.SetActive(false);
		hsPanel.SetActive(false);
		mainPanel.SetActive(true);
	}
	public void OpenHighScore()
	{
		optionPanel.SetActive(false);
		hsPanel.SetActive(true);
		mainPanel.SetActive(false);
	}
	
	public void Exit()
	{
		Application.Quit();
	}
}
