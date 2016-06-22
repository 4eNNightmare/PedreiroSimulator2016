using UnityEngine;
using System.Collections;

public class ScrFoguete : MonoBehaviour {

    public GameObject foguete;
    public Material ButtonOver;
    public Material ButtonNormal;


    void OnMouseOver()
    {
        GameObject.Find("BotaoRed").GetComponent<Renderer>().material = ButtonOver;
    }
    void OnMouseExit()
    {
        GameObject.Find("BotaoRed").GetComponent<Renderer>().material = ButtonNormal;
    }
    void OnMouseDown()
    {
        Instantiate(foguete, GameObject.Find("InstanciaFoguete").transform.position, GameObject.Find("InstanciaFoguete").transform.rotation);
        Destroy(this);
    }
    //void Update() {
    //    if (Input.GetMouseButtonDown(0)) {
    //        predios.GetComponent<Animator>().SetTrigger("Apocalipse");
    //        Instantiate(Particulas, predios.transform.position, predios.transform.rotation);
    //    }
    //}

}
