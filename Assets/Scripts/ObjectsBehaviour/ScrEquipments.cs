using UnityEngine;
using System.Collections;

public class ScrEquipments : ScrTransportableBehaviour
{
   void Update()
    {
        if (!scrPlayerEquipments.equipMission)
            base.catchSystem();
		base.Update();//chama o update do Transportable
		if (scrControls.use()){
			if (inHandObject != null) {
				switch (inHandObject.name) {
				case "capacete":
					if (scrPlayerEquipments.capacete == false) {
						scrPlayerEquipments.capacete = true;
						GameObject.Destroy (inHandObject);
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Parabens! Você equipou um capacete!", 0);
					} else {
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Você já está usando capacete.", 1);
					}
					break;
				case "luva_esquerda":
					if (scrPlayerEquipments.luvaEsquerda == false) {
						scrPlayerEquipments.luvaEsquerda = true;
						GameObject.Destroy (inHandObject);
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Parabens! Você equipou a luva esquerda!", 0);
					} else {
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Você já está usando uma luva nessa mão.", 1);
					}
					break;
				case "bota_esquerda":
					if (scrPlayerEquipments.botaEsquerda == false) {
						scrPlayerEquipments.botaEsquerda = true;
						GameObject.Destroy (inHandObject);
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Parabens! Você equipou a bota esquerda!", 0);
					} else {
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Você já está usando uma bota nesse pé.", 1);
					}
					break;
				case "luva_direita":
					if (scrPlayerEquipments.luvaDireita == false) {
						scrPlayerEquipments.luvaDireita = true;
						GameObject.Destroy (inHandObject);
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Parabens! Você equipou a luva direita!", 0);
					} else {
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Você já está usando uma luva nessa mão.", 1);
					}
					break;
				case "bota_direita":
					if (scrPlayerEquipments.botaDireita == false) {
						scrPlayerEquipments.botaDireita = true;
						GameObject.Destroy (inHandObject);
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Parabens! Você equipou a bota direita!", 0);
					} else {
						GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Você já está usando uma bota nesse pé.", 1);
					}
					break;
				default:
					GameObject.Find ("Canvas").GetComponent<scrMSG_Alert> ().DrawMsgBox ("Este equipamente está danificado!", 2);
					break;
				}
			}
		}
    }
}
