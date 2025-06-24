using UnityEngine;

//Este es el script del jugador el cual permite su movimiento y tiene valores que permiten su velocidad, vida y rango de interaccion
public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; //Velocidad
    public float interactRange = 3f; //Rango
    private Interact interactableInRange; //Referencia del objeto para interactuar
    public int health; //Cantidad de vida
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.E) && interactableInRange != null)
        {
            interactableInRange.Interact(); //Se llama al metodo Interact() del Objeto en rango al oprimir la tecla "E"
        }
    }
    //Metodo para recibir dañó
    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("El jugador recibe " + amount + " de daño. Salud restante: " + health);

        if (health <= 0)
        {
            Die();//Metodo que se llama cuando el jugador "Muere" 
        }
    }
    void Die()
    {
        Debug.Log("El jugador ha muerto");
        //Utilize un Debug.Log para poder interactuar con el resto de objetos/enemigos sin tener que reiniciar el proyercto
    }
    //Metodo que se llama al entrar en un Trigger
    private void OnTriggerEnter(Collider other)
    {
        Interact interactable = other.GetComponent<Interact>();
        if (interactable != null)
        {
            interactableInRange = interactable;
            Debug.Log("Cerca de: " + other.name + " (presiona E para interactuar)");
        }
    }
    //Metodo que se llama al salir del Trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Interact>() == interactableInRange)
        {
            Debug.Log("Saliste del rango de: " + other.name);
            interactableInRange = null;
        }
    }
}