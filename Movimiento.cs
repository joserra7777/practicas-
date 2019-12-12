using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    #region Variables globales
    public float velocidadRotacion;
    public float velocidad;
    public float fuerzaSalto;
    public bool Ensuelo;
    public bool registroSuma = false;
    public bool aceptarinsercion = true;
    Rigidbody rigidSalto;
    
    GameManager inventarioBalas;
   
    #endregion

    // Start is called before the first frame update
    void Start()
    {
       
        transform.position = new Vector3(0, 0, 0);
        velocidad = 6;
        inventarioBalas = FindObjectOfType<GameManager>();
        rigidSalto = GetComponent<Rigidbody>();
        fuerzaSalto = 8.0f;
        Ensuelo = true;
        
    }

    // Update is called once per frame
    void Update()

    {

        #region Contador de munición
        if (registroSuma == true && inventarioBalas.contadorTiposMunicion > 3)
        {
            inventarioBalas.contadorTiposMunicion++;
            registroSuma = false;
        }
        if (inventarioBalas.contadorTiposMunicion == 3 && registroSuma == true)
        {
            Debug.Log("Aguantaaaaaa");
            registroSuma = false;
        }

        if (inventarioBalas.contadorTiposMunicion >= inventarioBalas.balas.Length)
        {
            aceptarinsercion = false;
        }
        #endregion

        #region Control Movimiento
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position = transform.position + new Vector3(0, 0, -20f) * Time.deltaTime;
            transform.Translate(Vector3.forward * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position = transform.position + new Vector3(0, 0, -20f) * Time.deltaTime;
            transform.Translate(Vector3.back * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position = transform.position + new Vector3(0, 0, -20f) * Time.deltaTime;
            transform.Translate(Vector3.left * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position = transform.position + new Vector3(0, 0, -20f) * Time.deltaTime;
            transform.Translate(Vector3.right * 20f * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.Space) && Ensuelo == true)
        {
            rigidSalto.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            Ensuelo = false;
        }
        //rotacion 
        float anguloRotacion = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * anguloRotacion * velocidadRotacion * Time.deltaTime);
        #endregion



    }

    void OnCollisionEnter(Collision otro)
    {
        //Si la etiqueta es:
        if (otro.gameObject.tag == "Suelo")
        {
            Debug.Log("Me estás pisando");
            Ensuelo = true;

        }
        //O si la etiqueta es:
        if (otro.gameObject.tag == "balaItem" && aceptarinsercion == true) 
        {
            inventarioBalas.balas[inventarioBalas.contadorTiposMunicion++] = otro.gameObject;
            otro.gameObject.SetActive(false);
            Debug.Log("No me cargues");
            registroSuma = true;
        }
    }
} //Fin de la clase
