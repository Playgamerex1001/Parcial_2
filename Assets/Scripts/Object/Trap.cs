using UnityEngine;
//Script del objeto tipo Trampa
public class Trap : Object
{
    public int damage = 10;//Valor del daño que le infligiria al jugador
    private bool used = false;//Bool que permite la activacion de la trampa

    public override void Interact()
    {
        if (!used)//Se activa una sola vez debido a que el valor del Bool cambia
        {
            used = true;
            Debug.Log(objName + " activado: daño = " + damage);
        }
    }
}