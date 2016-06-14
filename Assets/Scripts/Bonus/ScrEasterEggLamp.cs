using UnityEngine;
using System.Collections;

public class ScrEasterEggLamp : MonoBehaviour {

    // Use this for initialization
    private bool lampIsActive = true;
    public Material materialLampEnabled;
    public Material materialLampDisabled;
    private GameObject hand;
    void Awake()
    {
        hand = GameObject.Find(CommonValues.handTranspStr);
    }

    void Update () {
        GameObject.Find("LampadaCasa").GetComponent<Light>().enabled = lampIsActive;

    }

    void OnMouseDown() {
        Debug.Log("clicou");
        if (lampIsActive && Vector3.Distance(hand.transform.position, transform.position) < CommonValues.maxGrabRange)
        {
            lampIsActive = false;
            GameObject.Find("ModelLamp").GetComponent<Renderer>().material = materialLampDisabled;
        }
        else if (!lampIsActive && Vector3.Distance(hand.transform.position, transform.position) < CommonValues.maxGrabRange)
        {
            lampIsActive = true;
            GameObject.Find("ModelLamp").GetComponent<Renderer>().material = materialLampEnabled;
        }
    }
}
