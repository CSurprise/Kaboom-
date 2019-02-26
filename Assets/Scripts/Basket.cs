using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket : MonoBehaviour
{
    Vector3 mouse = new Vector3(0, 0, 0);
    private float speed = 5;

    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mouse.x < 9.25 || mouse.x > -9.25)
        {
            transform.position = new Vector3(mouse.x, transform.position.y, 2);
        }
        if ((transform.position.x < 9.25 ) || (transform.position.x > -9.25))
        {
            if (Input.GetKey("left"))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey("right"))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        manager.SendMessage("counter");
    }
}
