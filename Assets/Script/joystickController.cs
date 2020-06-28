using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickController : MonoBehaviour
{
    //get object player
    public Transform player;

    //mengatur kecepatan
    public float speed = 5.0f;

    //Untuk Pengaktifan Joystick
    private bool touchStart = false;

    //Mendeteksi Pointer Joystick
    private Vector2 pointA, pointB;

    public Transform circle;
    public Transform outerCircle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Test Controller
        //moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            circle.transform.position = pointA * -1;
            outerCircle.transform.position = pointA * -1;
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStart = false;
        }
    }

    private void FixedUpdate()
    {
        if(touchStart){
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction * -1);

            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * -1;
        }

        else {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }  
    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }
}
