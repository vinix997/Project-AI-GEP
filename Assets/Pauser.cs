using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauser : MonoBehaviour {
	
	public GameObject pausePanel;
	// Use this for initialization
	int counter=0;
	public void Pause()
	{
		pausePanel.SetActive(true);
		Time.timeScale = 0;
	}	
	public void Resume()
	{
		pausePanel.SetActive(false);
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
			counter++;
		}
	
	}
}
