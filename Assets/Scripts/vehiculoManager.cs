using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiculoManager : MonoBehaviour
{
    public Vehiculo vehiculoScript;
    // Start is called before the first frame update
    void Start()
    {
        int cantRuedas = vehiculoScript.cantRuedas;
        Debug.Log("Cant Ruedas: " + vehiculoScript.cantRuedas);
        if (cantRuedas < 6)
        {
            vehiculoScript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
