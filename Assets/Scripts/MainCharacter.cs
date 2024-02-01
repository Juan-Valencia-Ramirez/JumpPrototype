using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    [SerializeField]
    public float breathLength;
    [SerializeField]
    public float breathSpeed;
    private void Update()
    {
        float sizeChange = breathLength * (Mathf.Sin(Time.realtimeSinceStartup * breathSpeed) + 0.5f);
        transform.localScale = Vector3.one + new Vector3(0, sizeChange, 0);
    }
}
