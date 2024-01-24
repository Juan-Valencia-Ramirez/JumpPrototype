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

    // Start is called before the first frame update
    void Start()
    {
        characterBase = LevelManager.Instance.MainCharacter.BasePosition;
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
