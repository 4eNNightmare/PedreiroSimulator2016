using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class  scrMSG_Alert : MonoBehaviour
{
	private Canvas c;
	public GameObject msgBox;
	public Vector3 msgBoxPos;
    private int vezesMaior;
	//public Image[] icons = new Image[2];
	[SerializeField]private Sprite iconsCheck;
	[SerializeField]private Sprite iconsAlert;
	[SerializeField]private Sprite iconsError;
    [SerializeField]private Sprite iconsEgg;


    void Awake()
    {
		c = GetComponent<Canvas>();
	}
	


	public void DrawMsgBox(string msg, int type)
    {
		GameObject instancia = Instantiate(msgBox) as GameObject;
		instancia.transform.SetParent(c.transform);
        int vezesMaior;
        

        switch (type){
		case 0:
			//normal
			instancia.GetComponent<Image>().color = new Color(0.23f,0.78f,0.17f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsCheck;
			break;

		case 1:
			//warning
			instancia.GetComponent<Image>().color = new Color(1f,0.85f,0.0f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsAlert;
			break;

		case 2:
			//erro
			instancia.GetComponent<Image>().color = new Color(0.78f,0.17f,0.17f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsError;
			break;
        case 3:
			//erro
			instancia.GetComponent<Image>().color = new Color(0.50f,0,0.48f,1);
			instancia.transform.FindChild("Icone").GetComponent<Image>().sprite = iconsEgg;
			break;

		}
		instancia.GetComponentInChildren<Text>().text = msg;
		msgBoxPos = new Vector3(c.GetComponent<RectTransform>().rect.width/2 - instancia.GetComponent<RectTransform>().rect.width / 2, c.GetComponent<RectTransform>().rect.height-20, 0);
        RectTransform instanciaTamanho = instancia.transform.FindChild("BackGround").GetComponent<RectTransform>();
        if (instancia.GetComponentInChildren<Text>().text.Length > 80)
        {
            Debug.Log("Antes" + instanciaTamanho.sizeDelta.y);
            vezesMaior = ((instancia.GetComponentInChildren<Text>().text.Length - 40) / 40);
            Debug.Log(vezesMaior);
            instanciaTamanho.sizeDelta = new Vector2(instanciaTamanho.sizeDelta.x, instanciaTamanho.sizeDelta.y + (20 * vezesMaior));
            instanciaTamanho.position = new Vector3(instanciaTamanho.position.x, instanciaTamanho.position.y - ((20 * vezesMaior)/2), 0);
            Debug.Log("Depois" +instanciaTamanho.sizeDelta.y);
        }
   
        instancia.GetComponent<RectTransform>().position = msgBoxPos;
	}
}
