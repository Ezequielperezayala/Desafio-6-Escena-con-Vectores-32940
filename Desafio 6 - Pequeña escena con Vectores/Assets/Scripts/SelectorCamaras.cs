using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorCamaras : MonoBehaviour
{
    public GameObject[] Camaras;
    [SerializeField] bool Seleccionado = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SelectionCamera();
        }

        
    }

    void SelectionCamera()
    {
        if (Seleccionado)
        {
            Seleccionado = false;
            Camaras[0].SetActive(false);
            Camaras[1].SetActive(true);
        }
        else if (Seleccionado == false)
        {
            Seleccionado = true;
            Camaras[0].SetActive(true);
            Camaras[1].SetActive(false);
        }
    }

}
