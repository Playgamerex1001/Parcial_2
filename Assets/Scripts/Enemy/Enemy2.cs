using UnityEngine;
//Script del enemigo2
public class Enemy2 : EnemyBase
{
    public int attackDamage = 20;//Valor del da�o que inflige

    public override void Interact()//Al interactuar el jugador y este enemigo2 reciben da�o
    {
        Player player = FindObjectOfType<Player>();
        if (player != null)
        {
            Debug.Log("Enemy2 ataca y causa 20 de da�o.");
            player.TakeDamage(attackDamage);//El jugador recibe da�o
        }
        base.Interact();//El enemigo2 recibe da�o
    }

    protected override void Die()
    {
        Debug.Log("Enemy2 ha muerto (pero atac� antes con 20 de da�o ( ?� ?? ?�))");
        Destroy(gameObject);//Al morir este enemigo2 desaparece
    }
}
