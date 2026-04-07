using UnityEngine;

public abstract class NPC : MonoBehaviour, IHurtable
{
    public float Health { get => _health; }

    [SerializeField] private float _health = 10;

    public float Damage { get => _damage; }

    [SerializeField] private float _damage = 1;
    public float AttackCooldown { get => _attackCooldown; }

    [SerializeField] private float _attackCooldown = 1;
    public float AttackSpeed{ get => _attackSpeed; }

    [SerializeField] private float _attackSpeed = 1;



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
}
