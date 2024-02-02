using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackablePipe : MonoBehaviour
{
    [SerializeField]
    private GameObject CrackPrefab;
    [SerializeField]
    private float XOffset;
    [SerializeField]
    private float YOffset;
    [Header("Internal")]
    [SerializeField]
    private bool Cracked = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 collisionPoint = collision.contacts[0].point;
        if (!Cracked && collisionPoint.y > transform.position.y)
        {
            Cracked = true;
            Vector3 crackPosition = transform.position + (new Vector3(0, YOffset, 0));
            crackPosition = new Vector3(collisionPoint.x + XOffset, crackPosition.y, collisionPoint.z);
            GameObject crack = Instantiate(CrackPrefab, crackPosition, Quaternion.identity);

            if (Random.Range(0f, 1f) > 0.5f)
            {
                crack.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }
}
