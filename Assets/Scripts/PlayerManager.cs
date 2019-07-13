using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Author : Chandra Delon

public class PlayerManager : MonoBehaviour {

	#region Singleton

	public static PlayerManager instance;
	public GameObject loseScreen;
	void Awake ()
	{
		instance = this;
	}

	#endregion

	public GameObject player;

	public void KillPlayer ()
	{
		loseScreen.SetActive(true);
	}

}
