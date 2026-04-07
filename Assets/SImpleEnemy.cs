using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public abstract class SimpleEnemy : NPC, IParryable, IPullable, IStunnable
{

    public Vector3 AttackLocalDirection { get => _attackLocalDirection; }

    [SerializeField] private Vector3 _attackLocalDirection;

    public bool IsStunned { get => _isStunned; }

    [SerializeField] private bool _isStunned;

    public float StunDuration { get => _stunDuration; }

    [SerializeField] private float _stunDuration;

    [SerializeField] private NodeSO Root, CurrentState;

    public NodeSO _root { get =>  _root; }
    public NodeSO _currentState { get => _currentState; }

    [HideInInspector] public NavMeshAgent agent;
    public Transform target;






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
