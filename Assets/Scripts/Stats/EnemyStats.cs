using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Keeps track of enemy stats, loosing health and dying. */

public class EnemyStats : CharacterStats{
	public GameObject minion;
	public int RandomScore;
	public static int decision = 0;
	public override void Die()
	{
		base.Die();
		// Add ragdoll effect / death animation
		GameManager.instance.score+=RandomScore;
		if(decision <=50)
		{
			Instantiate(minion,transform.position,Quaternion.identity);
		}
		Destroy(gameObject);
	}
	public void Update()
	{
		decision = Random.Range(0,100);
		RandomScore = Random.Range(8000,10000);
	}
	


}
