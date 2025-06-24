using UnityEngine;
//Script del objeto tipo Cofre
public class Chest : Object
{
    private bool isOpen = false;//Bool que indica el estado del cofre

    public override void Interact()
    {
        if (!isOpen)//"If" que permite conseguir el contenido del cofre 1 sola vez
        {
            isOpen = true;
            Debug.Log(objName + " abierto: conseguiste loot");
        }
        else Debug.Log(objName + " ya está abierto");
    }
}
