using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : Enemy
{
    public override void TakeDamage()
    {
        Die();
    }
    public override void Die()
    {
        Debug.Log("Enemy died.");
        Destroy(gameObject);
    }
}
