using UnityEngine;
//Clase base para enemigos donde se implementa el daño y la interacción
public abstract class EnemyBase : MonoBehaviour, Interact
{
    [SerializeField] private int maxHealth = 100;
    private int health;

    //Metodo que permite manejar la salud de los enemigos
    public int Health
    {
        get => health;
        set => health = Mathf.Clamp(value, 0, maxHealth);
    }

    protected virtual void Start()//Se aplica la salud a los enemigos al empezar
    {
        Health = maxHealth;
    }

    //Interacción por defecto le permite al enemigo recibir daño
    public virtual void Interact()
    {
        TakeDamage(20);
    }

    //Se actualiza la vida y se llama al metodo Die cuando la salud llega a 0
    public void TakeDamage(int amount)
    {
        if (amount <= 0) return;

        Health -= amount;
        Debug.Log($"{gameObject.name} recibe {amount} de daño. Salud restante: {Health}");

        if (Health == 0)
            Die();
    }
    protected abstract void Die();
}