using System.Linq;
using UnityEngine;

public class JumpBird : MonoBehaviour

{
    private Rigidbody2D body;
    [SerializeField]
    private float jumpStrength;
    [SerializeField]
    private float horizontalJumpStrength;
    [SerializeField]
    private float distToGroundCheck;
    [SerializeField]
    private Transform checkpoint1;
    [SerializeField]
    private Transform checkpoint2;

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
        RaycastHit2D[] hits1 = Physics2D.RaycastAll(checkpoint1.position, -Vector3.up, distToGroundCheck);
        RaycastHit2D[] hits2 = Physics2D.RaycastAll(checkpoint2.position, -Vector3.up, distToGroundCheck);
        if (hits1.Any(h => !h.collider.CompareTag("Player")) || hits2.Any(h => !h.collider.CompareTag("Player")))
        {
            if (Input.GetKeyDown(KeyCode.W))

            {
                body.velocity = Vector2.up * jumpStrength;
            }

            if (Input.GetKeyDown(KeyCode.D))

            {
                body.velocity = new Vector2(horizontalJumpStrength, jumpStrength);
                transform.localScale = Vector3.one;
            }

            if (Input.GetKeyDown(KeyCode.A))

            {
                body.velocity = new Vector2(-horizontalJumpStrength, jumpStrength);
                transform.localScale = new Vector3(-1, 1, 1);
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
