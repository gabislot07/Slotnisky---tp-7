using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] auto;

    // Start is called before the first frame update
    void Start()
    {
        vehiculoReset();
        float prom = 0;
        for (int i = 0; i < auto.Length; i++)
        {
            Vehiculo vehiculo = auto[i];
            prom += vehiculo.precioAlquiler;
        }
        Debug.Log(prom / auto.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetVehiculos();
            int numAleatoreo = Random.Range(0, auto.Length);
            auto[numAleatoreo].CartelPromo.gameObject.SetActive(true);
        }   
    }

    void vehiculoReset()
    {
        for (int i = 0; i< auto.Length; i++)
        {
            if (auto[i].cantRuedas > 4)
            {
                auto[i].CartelPromo.SetActive(false);
            }
        }
    }
    void ResetVehiculos()
    {
        foreach (Vehiculo vehiculo in auto)
        {
            vehiculo.CartelPromo.SetActive(false);
        }
    }
}
