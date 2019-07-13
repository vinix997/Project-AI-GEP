using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Author : Peter Andrew
public class EnemyController : MonoBehaviour {

	public float lookRadius = 10f;	// Detection range for player
    public bool isWander = true;
	Transform target;	// Reference to the player
	NavMeshAgent agent; // Reference to the NavMeshAgent
	CharacterCombat combat;
    public float newDest = 0;

	// Use this for initialization
	void Start () {
		target = PlayerManager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
		combat = GetComponent<CharacterCombat>();
	}
	
	// Update is called once per frame
	void Update () {
        newDest -= Time.deltaTime;
        if (isWander == true)
            if (newDest < 0)
            {
                agent.SetDestination(new Vector3(Random.Range(-1, -15), Random.Range(-1, -15), Random.Range(-1, -10)));
                newDest = 2.5f;
            }
           
		// Distance to the target
		float distance = Vector3.Distance(target.position, transform.position);

		// If inside the lookRadius
		if (distance <= lookRadius)
		{
            isWander = false;
			// Move towards the target
			agent.SetDestination(target.position);

			// If within attacking distance
			if (distance <= agent.stoppingDistance)
			{
				CharacterStats targetStats = target.GetComponent<CharacterStats>();
				if (targetStats != null)
				{
					combat.Attack(targetStats);
				}

				FaceTarget();	// Make sure to face towards the target
			}
        }
        else
        {
            isWander = true;
        }
	}

	// Rotate to face the target
	void FaceTarget ()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
	}

	// Show the lookRadius in editor
	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, lookRadius);
	}
}
