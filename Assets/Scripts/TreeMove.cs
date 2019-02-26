using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{

    public GameObject apple;
    public GameObject spawn;
    Vector3 direction = Vector3.right;
    
    private float speed = 5;

    float directionChangeChance = .01f;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (Random.value <= directionChangeChance)
        {
            speed *= -1;
            Instantiate(apple, spawn.transform);
        }

        if ((transform.position.x > 7.85) || (transform.position.x < -7.9))
        {
            speed *= -1;
        }

        
    }
}
