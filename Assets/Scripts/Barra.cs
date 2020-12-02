using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 1.0f;
    float height;

    //Siempre positivo!
    float posInicioBarraX = 6f;
    bool esDerecha;
    string input;

    // Start is called before the first frame update
    void Start()
    {
        //height = transform.localScale.y;
    }

    public void Init(bool _esDerecha){
        esDerecha = _esDerecha;

        Vector3 initPos = new Vector3(posInicioBarraX,0,0);

        if(esDerecha){
            this.gameObject.transform.position = initPos;
            this.gameObject.name = "BarraDerecha";
            input = "Derecha";
        } else {
            this.gameObject.transform.position = -initPos;
            this.gameObject.name = "Barraizquierda";
            input = "Izquierda";
        }

    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis(input) * velocidad;
        Vector3 pos = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(pos.x, pos.y + move, pos.z);

        //Debug.Log("Barra move= " + move);
     
     
    }
}
