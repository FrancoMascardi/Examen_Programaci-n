using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    public float producto_1;
    public float producto_2;
    public float producto_3;
    public string Nombre_1;
    public string Nombre_2;
    public string Nombre_3;
    public int Unidad_1;
    public int Unidad_2;
    public int Unidad_3;
    // Start is called before the first frame update
    void Start()
    {
        float monto;
        monto = producto_1 + producto_2 + producto_3;

        float porcentaje_1;
        float porcentaje_2;
        float porcentaje_3;
        porcentaje_1 = producto_1 * 0.2f / Unidad_1;
        porcentaje_2 = producto_2 * 0.2f / Unidad_2;
        porcentaje_3 = producto_3 * 0.2f / Unidad_3;

        if (Unidad_1 >= 3)
        {
            Debug.Log( Nombre_1 + " Tendra un descuento del %20, que le estaria quedando en " + porcentaje_1 + "pesos");
        }
        else if (Unidad_1 < 3)
        {
            Debug.Log( Nombre_1 + "No tendra descuento y el precio seria " + producto_1 + " pesos");
        }
        if (Unidad_2 >= 3)
        {
            Debug.Log( Nombre_2 + " Tendra un descuento del %20, que le estaria quedando en " + porcentaje_2 + "pesos");
        }
        else if (Unidad_2 <= 3)
        {
            Debug.Log( Nombre_2 + "No tendra descuento y el precio seria " + producto_2 + " pesos");
        }
        if (Unidad_3 >= 3)
        {
            Debug.Log( Nombre_3 + " Tendra un descuento del %20, que le estaria quedando en " + porcentaje_3 + "pesos");
        }
        else if (Unidad_3 < 3)
        {
            Debug.Log( Nombre_3 + "No tendra descuento y el precio seria " + producto_3 + " pesos");
        }
        if (Unidad_1 < 1)
        {
            Debug.Log("Error, no puede ingresar un valor menor a 1");
        }
        else if (Unidad_2 < 1)
        {
            Debug.Log("Error, no puede ingresar un valor menor a 1");
        }
        else if (Unidad_3 < 1)
        {
            Debug.Log("Error, no puede ingresar un valor menor a 1");
        }
        if (monto == producto_1 + producto_2 + producto_3)
        {
            Debug.Log("La suma total seria " + monto);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
