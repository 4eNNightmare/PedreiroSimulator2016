using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrMoney : MonoBehaviour
{
    private Text moneyText;
    private float moneyScore = 00.00f;

    void Awake()
    {
        moneyText = GetComponent<scrGameManager>().moneyText;
    }

    /** Update Money
    * @param operation -> CommonValues.ADD,CommonValues.SUB
    *
    */
    public void UpdateMoney(byte operation, float money)
    {
       switch(operation)
        {
            case CommonValues.ADD:
                {
                    moneyScore += money;
                }
                break;
            case CommonValues.SUB:
                {
                    moneyScore -= money;
                }
                break;

            default:
                Debug.LogError("UPDATEMONEY invalid operation");
                break;

        }

        moneyText.text = moneyScore.ToString();

    }


}
