using UnityEngine;

[CreateAssetMenu(fileName = "StunStateSO", menuName = "Scriptable Objects/StunStateSO")]
public class StunStateSO : NodeSO
{
    public override bool StateCondition(EnemyBehaviour eb)
    => eb.isStunned && !eb.isDead;
}
