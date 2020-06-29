using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Pemain : MonoBehaviour
{

    public float speed;
    private int idle;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        getMove();
    }

    private void getMove ()
    {
        if (CrossPlatformInputManager.GetAxis ("Horizontal") > 0)
        {
            transform.localScale = new Vector3(1, 1, 100);

            if (CrossPlatformInputManager.GetAxis ("Vertical") > 0)
            {
                Vector2 moveRec = new Vector2(1, 1) * speed;
                rigidbody.velocity = moveRec;
            }

            else if (CrossPlatformInputManager.GetAxis("Vertical") < 0)
            {
                Vector2 moveRec = new Vector2(1, -1) * speed;
                rigidbody.velocity = moveRec;
            }

            idle = 1;
        }

        else if (CrossPlatformInputManager.GetAxis("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-1, 1, 100);

            if (CrossPlatformInputManager.GetAxis("Vertical") > 0)
            {
                Vector2 moveRec = new Vector2(-1, 1) * speed;
                rigidbody.velocity = moveRec;
            }

            else if (CrossPlatformInputManager.GetAxis("Vertical") < 0)
            {
                Vector2 moveRec = new Vector2(-1, -1) * speed;
                rigidbody.velocity = moveRec;
            }

            idle = 1;
        }

        else
        {
            if (idle == 1)
            {
                Vector2 moveRec = new Vector2(0, 0);
                rigidbody.velocity = moveRec;
                idle = 0;
            }
        }
    }
}
