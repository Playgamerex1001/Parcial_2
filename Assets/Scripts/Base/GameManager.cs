using UnityEngine;
//Este Script es el GameMananger del juego que permite aparecer a los enemigos dentro del juego
public class GameManager : MonoBehaviour
{// Se coloca en el inspector los prefabs de los enemiigos 1 y 2
    public GameObject Enemy1;
    public GameObject Enemy2;
    public Transform[] spawnPoints; // Se coloca en el inspector los puntos de Spawn

    void Start() // Escoge un enemigo al azar y lo hace aparecer en uno de los 2 puntos de Spawn
    {
        foreach (Transform spawn in spawnPoints)
        {
            int random = Random.Range(0, 2);
            if (random == 0)
                Instantiate(Enemy1, spawn.position, spawn.rotation);
            else
                Instantiate(Enemy2, spawn.position, spawn.rotation);
        }
    }
}