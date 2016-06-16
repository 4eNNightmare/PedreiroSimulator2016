using UnityEngine;
using System.Collections;

public class onTriggerEnter : MonoBehaviour {

	void OnTriggerExit(Collider other){
		if(scrPlayerEquipments.botaDireita && scrPlayerEquipments.botaEsquerda 
		&& scrPlayerEquipments.capacete && scrPlayerEquipments.luvaDireita 
		&& scrPlayerEquipments.luvaEsquerda){
			GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Parabéns você equipou os EPI's.", 0);
		}
		else{
			GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Segundo a norma NR 6 da ABNT," +
				" deve-se equipar os EPI's antes de qualquer manuseio, volte e equipe-os!", 2);
			CommonValues.MoneyManager.UpdateMoney(CommonValues.SUB, 10f);
		}
	}
}
