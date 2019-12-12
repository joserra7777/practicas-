using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlUI : MonoBehaviour
{
    public Text[] interfazTXT;
    public GameObject jugador;
    public Score scoreText;
    // Start is called before the first frame update
    void Start()
    {
      
        scoreText = GetComponent<Score>();
        jugador = GameObject.FindGameObjectWithTag("Player");
        interfazTXT[0].text = "Vida: " + jugador.GetComponent<Vida>().vida.ToString();
        interfazTXT[1].text = "Score: " + scoreText.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            jugador.GetComponent<Vida>().vida -= 1;
            scoreText.score++;
        }
        interfazTXT[0].text = "Vida: " + jugador.GetComponent<Vida>().vida.ToString();
        interfazTXT[1].text = "Score: " + scoreText.score.ToString();
    }
}
