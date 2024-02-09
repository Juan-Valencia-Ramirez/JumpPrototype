using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flatStrength;
    public bool birdIsAlive = true;
    public LogicScript logicGrowing;

    // Start is called before the first frame update
    void Start()
    {
        logicGrowing = GameObject.FindGameObjectWithTag("LogicGrowing").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))

        {
            myrigidbody.velocity = Vector2.up * flatStrength;
        }

        if (Input.GetKeyDown(KeyCode.D))

        {
            myrigidbody.velocity = Vector2.right * flatStrength;
        }

        if (Input.GetKeyDown(KeyCode.A))

        {
            myrigidbody.velocity = Vector2.left * flatStrength;
        }
    }

    
}
