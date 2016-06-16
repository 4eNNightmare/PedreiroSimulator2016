using UnityEngine;
using System.Collections;

public class onTriggerEnter : MonoBehaviour
{
    private bool cameIn = false;
	void OnTriggerExit(Collider other)
    {
        if (cameIn)
            equipMission();
        else
            cameIn = true;
		
	}

    void equipMission()
    {
        if (scrPlayerEquipments.botaDireita && scrPlayerEquipments.botaEsquerda
        && scrPlayerEquipments.capacete && scrPlayerEquipments.luvaDireita
        && scrPlayerEquipments.luvaEsquerda)
        {
            GameObject.Find("Canvas").GetComponent<scrMSG_Alert>().DrawMsgBox("Parabéns você equipou os EPI's.", 0);
            CommonValues.MoneyManager.UpdateMoney(CommonValues.SUB, 10f);
            Destroy(this);
        }
        else {
            GameObject.Find("Canvas").GetComponent<scrMSG_Alert>().DrawMsgBox("Segundo a norma NR 6 da ABNT," +
                " deve-se equipar os EPI's antes de qualquer manuseio, volte e equipe-os!", 2);
            
        }
    }
}
