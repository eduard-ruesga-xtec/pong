using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    float speed;
    // Start is called before the first frame update
    float radius;
    Vector2 direction;
    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if(transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0){
            direction.y = -direction.y;
        }
        if(transform.position.y > GameManager.bottomRight.y + radius && direction.y > 0){
            direction.y = -direction.y;
        }

        if (transform.position.x < GameManager.bottomRight.x + radius && direction.x)
    }
}
