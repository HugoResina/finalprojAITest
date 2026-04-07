using UnityEngine;
using UnityEngine.AI;

public class meleeEnemy : SimpleEnemy
{
    public override Vector3 AttackLocalDirection {  get; set; }
    public override bool IsStunned {  get; set; }
    public override float StunDuration { get; set; }
    //public override NodeSO _root { get; set; }
    //public override NodeSO _currentState { get; set; }
    //public override Transform target { get; set; }
    public override float VisionDistance { get; set; }
    public override float Health { get; set; }
    public override float Damage { get; set; }
    public override float AttackCooldown { get; set; }
    public override float AttackSpeed { get; set; }
    public override float AttackRange { get; set; }

    public override void Attack()
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
}
