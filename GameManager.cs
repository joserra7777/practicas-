using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] balas;
    public int contadorTiposMunicion;
    

    // Start is called before the first frame update
    void Start()
    {
        balas = new GameObject[3];
        contadorTiposMunicion = 0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
