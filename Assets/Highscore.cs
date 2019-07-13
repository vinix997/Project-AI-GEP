using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Author : Chandra Delon
public class Highscore : MonoBehaviour {
	[SerializeField] private Text score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = PlayerPrefs.GetInt("Stage1 score", 0).ToString();
	}
}
