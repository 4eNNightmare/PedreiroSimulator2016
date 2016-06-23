using UnityEngine;
using System.Collections;

public class ScrApocalipse : MonoBehaviour {

    public GameObject predios;
    public GameObject Particulas;
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
        predios.GetComponent<Animator>().SetTrigger("Apocalipse");
        Instantiate(Particulas, predios.transform.position, predios.transform.rotation);
        Destroy(this);
    }
    //void Update() {
    //    if (Input.GetMouseButtonDown(0)) {
    //        predios.GetComponent<Animator>().SetTrigger("Apocalipse");
    //        Instantiate(Particulas, predios.transform.position, predios.transform.rotation);
    //    }
    //}

}
