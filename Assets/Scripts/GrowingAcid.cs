using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingAcid : MonoBehaviour
{
    [SerializeField]
    private float growSpeed;
    void Update()
    {
        transform.position += Vector3.up * growSpeed * Time.deltaTime;
    }
}
