using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour {

	public float attackSpeed = 1f;
	private float attackCooldown = 0f;
    const float combatCooldown = 5;
    float lastAttackTime;
    public float offsphere = 0;
    public float spherecool = 0;
	public float attackDelay = .6f;
    Collider sphere;
    public bool InCombat { get; private set; }
	public event System.Action OnAttack;
	public bool status;
	CharacterStats myStats;
    CharacterStats opponentStats;

	void Start ()
	{
		myStats = GetComponent<CharacterStats>();
        sphere = GetComponent<SphereCollider>();
	}

	void Update ()
	{
       
        attackCooldown -= Time.deltaTime;
        splashAttack();
    }
    private void splashAttack()
    {
        if (gameObject.tag == "Player")
        {
            offsphere -= Time.deltaTime;
            spherecool -= Time.deltaTime;
            if (offsphere <= 0)
                sphere.enabled = false;
            if (Input.GetMouseButtonDown(1) && spherecool < 0)
            {
                sphere.enabled = true;
                offsphere = .01f;
                spherecool = 3f;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            opponentStats = other.GetComponent<CharacterStats>();
            opponentStats.TakeDamage(myStats.damage.GetValue());
        }
        
    }

    public void Attack (CharacterStats targetStats)
	{
		if (attackCooldown <= 0f)
		{
            opponentStats = targetStats;
			if (OnAttack != null)
				OnAttack();
			attackCooldown = 1f / attackSpeed;
            InCombat = true;
            lastAttackTime = Time.time;

		}
		
	}


    public void AttackHit_AnimationEvent()
    {
        opponentStats.TakeDamage(myStats.damage.GetValue());
        if (opponentStats.currentHealth <= 0)
		{
			InCombat = false;
			
		}
    }

}
