using UnityEngine;
using UnityEngine.AI;

public class meleeEnemy : SimpleEnemy
{
    private void Awake()
    {
        this.agent = GetComponent<NavMeshAgent>();
    }
}
