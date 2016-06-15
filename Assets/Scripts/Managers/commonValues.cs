using UnityEngine;
using System.Collections;

public static class CommonValues {
	public static string handTranspStr =  "mao";
	public static Color tranportableHLColor = new Color(0,1,0,1);
	public static Color nonTranportableHLColor = new Color(0,0,1,1);
	public static float maxGrabRange = 2;
    public const int INFO=0,ALERT = 1, ERROR = 2;
    public const byte ADD = 0, SUB = 1, MULT = 2, DIV = 3;

    private static scrGameManager GameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<scrGameManager>();
    public static scrMoney MoneyManager = GameManager.GetComponent<scrMoney>();
}