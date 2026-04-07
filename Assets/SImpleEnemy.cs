using Unity.VisualScripting;
using UnityEngine;

public abstract class SimpleEnemy : NPC, IParryable, IPullable, IStunnable
{
    public float Health { get => _health; }

    [SerializeField] private float _health = 10;

    public float Damage { get => _damage; }

    [SerializeField] private float _damage = 1;
    public float AttackCooldown { get => _attackCooldown; }

    [SerializeField] private float _attackCooldown = 1;
    public float AttackSpeed { get => _attackSpeed; }

    [SerializeField] private float _attackSpeed = 1;

    public Vector3 AttackLocalDirection { get => _attackLocalDirection; }

    [SerializeField] private Vector3 _attackLocalDirection;

    public bool IsStunned { get => _isStunned; }

    [SerializeField] private bool _isStunned;

    public float StunDuration { get => _stunDuration; }

    [SerializeField] private float _stunDuration;



    public void Die()
    {
        Debug.Log("Entity Dies");
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("Entity Takes " + damage + " damage");
    }
    public void Attack()
    {
        Debug.Log("Entity Attacks with " + _damage + " damage");
    }

    public void Parry()
    {
        Debug.Log("attack gets parried");
    }

    public void OpenParryWindo()
    {
        Debug.Log("parry window opened");
    }

    public void CloseParryWindow()
    {
        Debug.Log("parry window closed");
    }

    public void Pull()
    {
        Debug.Log("Pulled");
    }

    public void Stun()
    {
        Debug.Log("stunned");
    }

    public void ClearStun()
    {
        Debug.Log("stun cleared");
    }
}
