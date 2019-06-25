using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public float spawnTimer=30f;
	float cooldown=0;
	public GameObject Enemy;
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cooldown+=Time.deltaTime;
		if(cooldown>=spawnTimer)
		{
			cooldown=0;
			Instantiate(Enemy,transform.position,Quaternion.identity);
		}
	}
}
