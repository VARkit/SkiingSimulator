using UnityEngine;

public class WrongColision : MonoBehaviour
{
    public GameObject red_screen;
    FinishStatistic TimerDist;
    AudioSource AudioSource;
    public float playerNum;
    private void Start()
    {
        TimerDist = GameObject.Find("FinCanv").GetComponent<FinishStatistic>();
        AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {  
        if (playerNum == GameObject.Find("netSync").GetComponent<OnJoinedRoom>().PlayerNum)
        {
            OnWrongCol();
        }
    }
    public void OnWrongCol()
    {
        GetComponent<BoxCollider>().enabled = false;
        red_screen.SetActive(true);
        TimerDist.collisions++;
        AudioSource.Play();

    }
}
