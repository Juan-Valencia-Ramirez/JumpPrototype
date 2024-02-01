using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizonBlockMov : MonoBehaviour
{
    [SerializeField]
    private Vector3 speed;
    [SerializeField]
    private float movementLength;
    [Header("internal")]
    [SerializeField]
    private Vector3 startPosition;
    [SerializeField]
    private float turnTime;
    [SerializeField]
    private float pendingTurnTime;
    [SerializeField]
    private int direction;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        turnTime = movementLength / Vector3.Magnitude(speed);
        pendingTurnTime = turnTime;
        direction = 1;
    }
    private void Update()
    {

        //transform.position += speed * direction * Time.deltaTime;
        body.velocity = speed * direction;
        pendingTurnTime -= Time.deltaTime;
        
        if (pendingTurnTime <= 0)
        {
            if (direction == -1)
            {
                transform.position = startPosition;
            }
            direction *= -1;
            pendingTurnTime = turnTime;
        }
    }
    private void OnDrawGizmos()
    {
        Vector3 position = startPosition == Vector3.zero ? transform.position : startPosition;
        Gizmos.color = Color.green;
        turnTime = movementLength / Vector3.Magnitude(speed);
        Gizmos.DrawLine(position, position + (speed * turnTime));   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag)
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //collision.collider.transform.SetParent(null);
        }
    }
}
