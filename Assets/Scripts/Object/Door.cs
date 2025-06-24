using UnityEngine;
//Script del objeto tipo Puerta
public class Door : Object
{
    private bool locked = true;//Bool que indica el estado de la puerta

    public override void Interact()
    {
        if (locked)
        {
            locked = false;
            Debug.Log(objName + " desbloqueado y abierto");
        }
        else
            Debug.Log(objName + " ya está abierto");
    }
}
