using UnityEngine;
using System.Collections;

public class scrGameManager:MonoBehaviour
{
    public GameObject player;
    public Canvas gameCanvas;

#if UNITY_EDITOR
    void Awake()
    {
        if (player == null)
            Debug.LogError("Player is not defined in GameManager!!!");

        if (gameCanvas == null)
        {
            Debug.LogError("Canvas is not set in GameManager!!!");
        }
    }
#endif

    void Start()
    {
        //Start Game

        gameCanvas.GetComponent<scrMSG_Alert>().DrawMsgBox("Pegue seus equipamentos de EPI", CommonValues.INFO);

    }
}
