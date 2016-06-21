using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrIntro : MonoBehaviour {

    public MovieTexture movie;
    public float movieTime;
    void Start()
    {

        GetComponent<RawImage>().texture = movie as MovieTexture;
        movie.Play();
        StartCoroutine(TempoIntro(movieTime));
    }

    IEnumerator TempoIntro(float time)
    {

        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Scene0");

    }
}
