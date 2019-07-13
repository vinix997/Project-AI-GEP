using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionStats : CharacterStats {

	// Use this for initializationpublic class EnemyStats : CharacterStats{
	public override void Die()
	{
		base.Die();
		// Add ragdoll effect / death animation
		GameManager.instance.score+=1500;
		
		Destroy(gameObject);
	}
	
	


}

