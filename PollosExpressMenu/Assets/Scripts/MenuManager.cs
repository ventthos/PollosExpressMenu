using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static Producto ProductoActual;

    public static void SetProducto(Producto producto)
    {
        Debug.Log("Producto seleccionado: " + producto.Nombre);
        ProductoActual = producto;
    }
}
