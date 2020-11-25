using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    float speed = 5f;
    float height;

    string input;
    bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
    }

    public void Init(bool isRightPaddle){
        isRight = isRightPaddle;

        Vector2 pos  = Vector2.zero;

        if(isRightPaddle){
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;

            input = "BarraIzquierda";
        } else {
            
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos -= Vector2.right * transform.localScale.x;

            input = "BarraDerecha";
        }

    }

    // Update is called once per frame
    void Update()
    {
     float move = Input.GetAxis(input) * Time.deltaTime * speed;
     if(transform.position.y < GameManager.bottomleft.y + height/2 && move<0) {
         move = 0;
     }
     if(transform.position.y > GameManager.bottomRight.y - height/2 && move<0) {
         move = 0;
     }
     transform.Translate (move*Vector2.up);   
    }
}
