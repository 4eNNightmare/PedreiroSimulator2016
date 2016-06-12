using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrMSG_Alert : MonoBehaviour
{
	private Canvas c;
	public GameObject msgBox;
	public Vector3 msgBoxPos;
	//public Image[] icons = new Image[2];
	[SerializeField]private Sprite iconsCheck;
	[SerializeField]private Sprite iconsAlert;
	[SerializeField]private Sprite iconsError;

	void Awake()
    {
		c = GetComponent<Canvas>();
	}
	


	public void DrawMsgBox(string msg, int type)
    {
		GameObject instancia = Instantiate(msgBox) as GameObject;
		instancia.transform.SetParent(c.transform);

		switch (type){
		case 0:
			//normal
			instancia.GetComponent<Image>().color = new Color(0.23f,0.78f,0.17f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsCheck;
			break;

		case 1:
			//warning
			instancia.GetComponent<Image>().color = new Color(0.78f,0.39f,0.17f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsAlert;
			break;

		case 2:
			//erro
			instancia.GetComponent<Image>().color = new Color(0.78f,0.17f,0.17f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsError;
			break;

		}
		instancia.GetComponentInChildren<Text>().text = msg;
		msgBoxPos = new Vector3(0,c.GetComponent<RectTransform>().rect.height, 0);
		instancia.GetComponent<RectTransform>().position = msgBoxPos;
	}
}
