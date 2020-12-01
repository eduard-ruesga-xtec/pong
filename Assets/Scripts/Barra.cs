using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    float velocidad = 1.0f;
    float height;

    string input;
    bool esDerecha;
    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
    }

    public void Init(bool _esDerecha){
        esDerecha = _esDerecha;


        if(_esDerecha){
        
        } else {
       
        }

    }

    // Update is called once per frame
    void Update()
    {
     float move = Input.GetAxis(input) * Time.deltaTime * velocidad;
     
     
    }
}
