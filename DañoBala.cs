using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBala : MonoBehaviour
{
    public Score scoreSuma;

    void Start()
    {
        scoreSuma = FindObjectOfType<Score>();
    }
     void OnCollisionEnter(Collision otroEnemigo)
    {
        if (otroEnemigo.gameObject.tag == "Enemigo")
        {
            scoreSuma.score += 10;
            Destroy(otroEnemigo.gameObject);
            Destroy(this.gameObject);
        }
    }
}
