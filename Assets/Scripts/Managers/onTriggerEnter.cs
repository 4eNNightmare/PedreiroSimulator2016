using UnityEngine;
using System.Collections;

public class onTriggerEnter : MonoBehaviour {

	void OnTriggerExit(Collider other){
		if(scrPlayerEquipments.botaDireita && scrPlayerEquipments.botaEsquerda 
		&& scrPlayerEquipments.capacete && scrPlayerEquipments.luvaDireita 
		&& scrPlayerEquipments.luvaEsquerda){
			GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("O paulo é tipo ruim e tem problema na cama", 0);
		}
		else{
			GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Vai ser burro, quer morrer desgraça, volta la e equipa essa porra", 2);
		}
	}
}
