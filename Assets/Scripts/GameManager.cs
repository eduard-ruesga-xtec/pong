using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Bola bola;
    public Barra barra;

    public float BottomLeft;
    public float TopRight;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate (bola);

        Instantiate (barra);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
