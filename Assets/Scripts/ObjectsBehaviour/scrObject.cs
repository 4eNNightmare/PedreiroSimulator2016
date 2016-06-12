using UnityEngine;
using System.Collections;

public abstract class ScrObject : MonoBehaviour{
	public bool selectable = true;
	public bool targeted;
	public string info;

	public void Highlight(GameObject g, Color color)
    {
        if (selectable)
        {
            g.gameObject.GetComponent<Renderer>().material.SetColor("_OutlineColor", color);

            if (color != new Color(0, 0, 0, 0))
            {
                g.gameObject.GetComponent<Renderer>().material.SetFloat("_Outline", 0.02f);
            }
            else
            {
                g.gameObject.GetComponent<Renderer>().material.SetFloat("_Outline", 0f);
            }
        }
    }

	public void ShowInfo(){
		if(targeted){
			Debug.Log(info);
		}

	}
}