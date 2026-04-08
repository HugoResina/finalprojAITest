using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;

public class meleeEnemy : SimpleEnemy
{
    public override Vector3 AttackLocalDirection {  get; set; }
    public override float StunDuration { get; set; }
    public override bool IsStunned { get; set; }
    public override float VisionDistance { get; set; }
    public override float Health { get; set; }
    public override float Damage { get; set; }
    public override float AttackCooldown { get; set; }
    public override float AttackSpeed { get; set; }
    public override float AttackRange { get; set; }

    [SerializeField] private LayerMask playerLayer;

    [SerializeField] private LayerMask companionLayer;

    [SerializeField] private NPC Target;

    private void Start()
    {
        ChooseState();
    }

    public void ChooseState()
    {
        if (Health <= 0) Die();
        if (IsStunned) Stun();
        else if(Target != null && !IsStunned)
        {
            float distance = Vector3.Distance(Target.transform.position, this.transform.position);
            if (distance <= AttackRange)
            {
                Attack(Target);
            }
            else if (distance <= VisionDistance)
            {
                Chase(Target);
            }
            else 
            {
                //idle?
            }
        }
        //idle?

        
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.transform.gameObject.layer == playerLayer || other.transform.gameObject.layer == companionLayer)
        {

        }
    }


    public override void Attack(IHurtable Target)
    {
    }

    public override void ClearStun()
    {
    }

    public override void CloseParryWindow()
    {
    }

    public override void Die()
    {
    }

    public override void OpenParryWindo()
    {
    }

    public override void Parry()
    {
    }

    public override void Pull()
    {
    }

    public override void Stun()
    {
    }

    public override void TakeDamage(float damage)
    {
    }
    public override void Chase(NPC Target)
    {
    }
}
