using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    public GameObject Start;
    public GameObject countdown;
    public GameObject canvas;
    public Impulse Impulse;
    public AudioSource AudioSource;
    public AudioSource Ambient;

    public void OnStart()
    {
        StartCoroutine(startint());
    }

    public IEnumerator startint()
    {
        AudioSource.enabled = false;
        Start.SetActive(true);
        countdown.GetComponent<Image>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        canvas.SetActive(false);
        Impulse.DoImpulse();
        Ambient.Play();

    }
    public void SourcePlay()
    {
        AudioSource.Play();
    }
}
