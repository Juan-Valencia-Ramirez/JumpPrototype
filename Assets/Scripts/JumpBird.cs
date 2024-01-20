using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBird : MonoBehaviour

{
    private Rigidbody2D body;
    [SerializeField]
    private float jumpStrength;
    [SerializeField]
    private float horizontalJumpStrength;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (body.velocity.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.W))

            {
                body.velocity = Vector2.up * jumpStrength;
            }

            if (Input.GetKeyDown(KeyCode.D))

            {
                body.velocity = new Vector2(horizontalJumpStrength, jumpStrength);
            }

            if (Input.GetKeyDown(KeyCode.A))

            {
                body.velocity = new Vector2(-horizontalJumpStrength, jumpStrength);
            }

        }
    }

    public float BaseY
    {
        get
        {
            return transform.position.y;
        }
    }
}
