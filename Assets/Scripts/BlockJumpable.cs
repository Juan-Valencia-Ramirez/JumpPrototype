using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockJumpable : MonoBehaviour
{
    [SerializeField]
    private Transform blockBase;
    [Header("Internal")]
    [SerializeField]
    private Transform characterBase;
    private BoxCollider2D body;
    private void Awake()
    {
        body = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        body.enabled = characterBase.position.y > blockBase.position.y;
    }
    private void OnDrawGizmosSelected()
    {
        if (body != null && body.enabled)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, 0.1f);
        }
    }
}
