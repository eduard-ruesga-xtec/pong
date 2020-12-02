using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Bola bola;
    public Barra barra;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate (bola);

        Barra barraDerecha = Instantiate (barra);
        Barra barraIzquierda = Instantiate(barra);

        barraDerecha.Init(true);
        barraIzquierda.Init(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
