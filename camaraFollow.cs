using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraFollow : MonoBehaviour
{
    public GameObject followTarget;
    public float moveSpeed;
    public Vector3 puntoDePartida = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        puntoDePartida = transform.position - followTarget.transform.position;

    }

    // Update is called once per frame
    void Update()
    {



        if (followTarget != null)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.transform.position + puntoDePartida, Time.deltaTime * moveSpeed);
        }
    }
}
