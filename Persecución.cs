using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Scrollbar;

public class Persecución : MonoBehaviour
{
    public Transform playerPosition;
    public float velEnemigo;
    public float magnitudeDist;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
         
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = new Vector3(playerPosition.position.x, transform.position.y, playerPosition.position.z);
        float distancia = Vector3.Distance(transform.position, playerPos);
        Vector3 direccion = playerPos - transform.position;
        if (direccion.magnitude<magnitudeDist)
        {
            voltear hacia objetivo
            transform.LookAt(playerPosition);
            transform.Translate(Vector3.forward * velEnemigo * Time.deltaTime);
        }
      
    }
}
