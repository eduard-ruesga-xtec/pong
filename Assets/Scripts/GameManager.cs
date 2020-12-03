using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Bola bola;
    public Barra barra;

    public Vector2 limiteArribaIzquierda;
    public Vector2 limiteAbajoDerecha;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate (bola);

        Barra barraDerecha = Instantiate (barra);
        Barra barraIzquierda = Instantiate(barra);

        barraDerecha.Init(true);
        barraIzquierda.Init(false);

        limiteAbajoDerecha    = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        limiteArribaIzquierda = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        Debug.Log(this.gameObject.name + " limiteArribaIzquierda= " + limiteArribaIzquierda);
        Debug.Log($"{this.gameObject.name} limiteAbajoDerecha= {limiteAbajoDerecha}");
        
    }
}
