using UnityEngine;

public class WrongColision : MonoBehaviour
{
    public GameObject red_screen;
    FinishStatistic TimerDist;
    AudioSource AudioSource;
    public float playerNum;
    public FinStatSync sync;
    bool stop;
    private void Start()
    {
        TimerDist = GameObject.Find("FinCanv").GetComponent<FinishStatistic>();
        AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {       
        OnWrongCol();      
    }
    public void OnWrongCol()
    {
        if (playerNum == GameObject.Find("netSync").GetComponent<OnJoinedRoom>().PlayerNum && !stop)
        {
            GetComponent<BoxCollider>().enabled = false;
            red_screen.SetActive(true);
            if (playerNum == 1)
            {
                sync.colFirst++;
            }
            else
            {
                sync.ColSecond++;
            }
            AudioSource.Play();
            stop = true;
        }
    }
}
