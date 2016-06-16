using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrGameManager:MonoBehaviour
{
    public GameObject player;
    public Canvas gameCanvas;
    public Text moneyText;

    //Start the money system;
    public scrMoney moneyManager;

#if UNITY_EDITOR
    void Awake()
    {
        if (player == null)
            Debug.LogError("Player is not defined in GameManager!!!");

        if (gameCanvas == null)
        {
            Debug.LogError("Canvas is not set in GameManager!!!");
        }

        if (moneyText == null)
        {
            Debug.LogError("MONEY TEXT not set in GameManager!!!!");
        }

        loadResources();

    }
#endif

    void Start()
    {
        
        //Start Game
		gameCanvas.GetComponent<scrMSG_Alert>().DrawMsgBox("Equipe os EPI's e transporte os materiais para uma area segura. ", CommonValues.ALERT);

    }

    void loadResources()
    {
        moneyManager = GetComponent<scrMoney>();
    }

}
