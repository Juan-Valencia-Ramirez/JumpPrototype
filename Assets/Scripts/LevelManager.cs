using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [SerializeField]
    private MainCharacter mainCharacter;

    public MainCharacter MainCharacter { get { return mainCharacter; } }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            GameObject.Destroy(this);
        }
    }
}
