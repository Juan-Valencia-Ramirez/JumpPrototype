using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flatStrength;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true )

        {
            myrigidbody.velocity = Vector2.up * flatStrength;
        }

        if (Input.GetKeyDown(KeyCode.D) == true)

        {
            myrigidbody.velocity = Vector2.right * flatStrength;
        }

        if (Input.GetKeyDown(KeyCode.A) == true)

        {
            myrigidbody.velocity = Vector2.left * flatStrength;
        }
    }
}
