using UnityEngine;
using System.Collections;

public class scrGameManager
{
    public GameObject player;

#if UNITY_EDITOR
    void Awake()
    {
        if (player == null)
            Debug.LogError("Player is not defined in GameManager!!!");
    }
#endif
}
