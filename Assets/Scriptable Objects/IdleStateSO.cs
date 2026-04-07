using UnityEngine;

[CreateAssetMenu(fileName = "IdleStateSO", menuName = "Scriptable Objects/IdleStateSO")]
public class IdleStateSO : NodeSO
{
    public override bool StateCondition(EnemyBehaviour eb) => !eb.isChasing && !eb.isDead;

    public override void OnStart(EnemyBehaviour eb)
    {
        //cosas del idle?
    }
}
