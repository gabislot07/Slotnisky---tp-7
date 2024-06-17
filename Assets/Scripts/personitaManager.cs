using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personitaManager : MonoBehaviour
{
    public personitaScript[] personitas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < personitas.Length; i++)
            {
                personitaScript persona = personitas[i];
                personitaScript pScript = persona.GetComponent<personitaScript>();
                pScript.gameObject.SetActive(false);
            }
        }
    }
}
