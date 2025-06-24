using UnityEngine;
//Script simple de enemigo1
public class Enemy1 : EnemyBase
{
    protected override void Die()
    {
        Debug.Log("Enemy1 ha muerto");
        Destroy(gameObject);//El enemigo desaparece al morir
    }
}
