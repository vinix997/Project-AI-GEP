using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Keeps track of the player */

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
