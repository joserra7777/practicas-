using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    #region Variables
    [Header("Bala")]
    public Rigidbody bala;
    [Header("cañon")]
    public Transform cañon;
    [Header("fuerza")]
    public float fuerzaDisparo;
    public int tiposDeDisparo;
    GameManager inventarioBalas;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        inventarioBalas = FindObjectOfType<GameManager>();
        tiposDeDisparo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        #region Tipos de disparo
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            tiposDeDisparo = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            tiposDeDisparo = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            tiposDeDisparo = 2;
        }
        #endregion
        #region control disparo
        if (Input.GetMouseButton(0))
        {
            Rigidbody balaPos = Instantiate(bala, cañon.position, cañon.rotation) as Rigidbody;
            balaPos.AddForce(cañon.forward * fuerzaDisparo);

        }
        #endregion
    }
    void SeleccionMunicion()
    {
        Debug.Log("Baaaang");
        Rigidbody balaPos = Instantiate(inventarioBalas.balas[tiposDeDisparo].GetComponent<Rigidbody>(), cañon.position, cañon.rotation) as Rigidbody;
        balaPos.gameObject.SetActive(true);
        balaPos.constraints = RigidbodyConstraints.None;
        balaPos.AddForce(cañon.forward * fuerzaDisparo);
    }
    void MunicionSimple()
    {
        Rigidbody balaPos = Instantiate(bala, cañon.position, cañon.rotation) as Rigidbody;
        balaPos.AddForce(cañon.forward * fuerzaDisparo);

    }

}
