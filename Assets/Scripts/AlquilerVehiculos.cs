using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculosStart();
        float promedio = 0;
        for (int i = 0; i < vehiculos.Length; i++)
        {
            Vehiculo vehiculo = vehiculos[i];
            promedio += vehiculo.precioAlquiler;
        }
        Debug.Log(promedio / vehiculos.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetearVehiculos();
            int numAleatoreo = Random.Range(0, vehiculos.Length);
            vehiculos[numAleatoreo].CartelPromo.gameObject.SetActive(true);
        }   
    }

    void ResetearVehiculosStart()
    {
        for (int i = 0; i<vehiculos.Length; i++)
        {
            if (vehiculos[i].cantRuedas > 4)
            {
                vehiculos[i].CartelPromo.SetActive(false);
            }
        }
    }
    void ResetearVehiculos()
    {
        foreach (Vehiculo vehiculo in vehiculos)
        {
            vehiculo.CartelPromo.SetActive(false);
        }
    }
}
