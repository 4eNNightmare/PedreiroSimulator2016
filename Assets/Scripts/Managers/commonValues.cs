using UnityEngine;
using System.Collections;

public static class CommonValues {
	public static string handTranspStr =  "mao";
	public static Color tranportableHLColor = new Color(0,1,0,1);
	public static Color nonTranportableHLColor = new Color(0,0,1,1);
	public static float maxGrabRange = 2;
    public const int INFO=0,ALERT = 1, ERROR = 2, EGG = 3;
    public const byte ADD = 0, SUB = 1, MULT = 2, DIV = 3;

    private static scrGameManager GameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<scrGameManager>();
    public static scrMoney MoneyManager = GameManager.GetComponent<scrMoney>();
    public static scrMSG_Alert MessageManager = GameObject.FindGameObjectWithTag("gameGUI").GetComponent<scrMSG_Alert>();
   
    //Common Tag
    public const string tagTijolo = "matTijolo";
    public const string tagCimento = "matCimento";
    public const string tagTriggers = "Triggers";
    
    //Money Common Pontuation
    public static float _moneyFineTijolo = 5f, _moneyBreakTijolo = 5f;
    public static float _moneyFineCimento = 10f, _moneyBreakCimento = 10f;

    public const byte REWARD = 0, PUNISH = 1;



    public static void moneyReward(string tag, byte reward)
    {
        switch(tag)
        {
            case tagCimento:
                    if (reward == REWARD)
                        MoneyManager.UpdateMoney(ADD, _moneyFineCimento);
                    else
                        MoneyManager.UpdateMoney(SUB, _moneyBreakCimento);
                break;

            case tagTijolo:
                if (reward == REWARD)
                    MoneyManager.UpdateMoney(ADD, _moneyFineTijolo);
                else
                    MoneyManager.UpdateMoney(SUB, _moneyBreakTijolo);
                break;

            default: Debug.LogError("Invalid Tag and/or reward in CommonValues"); break;
        }
    }

}