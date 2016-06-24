using UnityEngine;
using System.Collections;

public class ScrFoguete : MonoBehaviour {

    public GameObject foguete;
    public Material ButtonOver;
    public Material ButtonNormal;


    void OnMouseOver()
    {
        transform.FindChild("BotaoRed").GetComponent<Renderer>().material = ButtonOver;
    }
    void OnMouseExit()
    {
        transform.FindChild("BotaoRed").GetComponent<Renderer>().material = ButtonNormal;
    }
    void OnMouseDown()
    {
        Instantiate(foguete, GameObject.Find("InstanciaFoguete").transform.position, GameObject.Find("InstanciaFoguete").transform.rotation);
        CommonValues.MessageManager.DrawMsgBox("Parabéns senhor curioso, você lançou um foguete da nas... Ih! E acho que isso vai dar zebra!", CommonValues.EGG);
        Destroy(this);
    }
    //void Update() {
    //    if (Input.GetMouseButtonDown(0)) {
    //        predios.GetComponent<Animator>().SetTrigger("Apocalipse");
    //        Instantiate(Particulas, predios.transform.position, predios.transform.rotation);
    //    }
    //}

}
