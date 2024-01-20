using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockJumpable : MonoBehaviour
{
    private BoxCollider2D body;
    [SerializeField]
    private Transform characterBase;
    [SerializeField]
    private Transform blockBase;
    
    private void Awake()
    {
        body = GetComponent<BoxCollider2D>();


    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(blockBase.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        body.enabled = characterBase.position.y > blockBase.position.y;
        //Debug.Log(characterBase.position.y);

        //if (body.enabled)
        //{
        //    Debug.Break();
        //}
    }
}
