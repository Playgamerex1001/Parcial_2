using UnityEngine;
//Script del enemigo2
public class Enemy2 : EnemyBase
{
    public int attackDamage = 20;//Valor del daño que inflige

    public override void Interact()//Al interactuar el jugador y este enemigo2 reciben daño
    {
        Player player = FindObjectOfType<Player>();
        if (player != null)
        {
            Debug.Log("Enemy2 ataca y causa 20 de daño.");
            player.TakeDamage(attackDamage);//El jugador recibe daño
        }
        base.Interact();//El enemigo2 recibe daño
    }

    protected override void Die()
    {
        Debug.Log("Enemy2 ha muerto (pero atacó antes con 20 de daño ( ?° ?? ?°))");
        Destroy(gameObject);//Al morir este enemigo2 desaparece
    }
}
