using UnityEngine;
using TMPro;
public class timer_dist : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI time_text;
    bool _started;
    public Transform Finish;
    public Transform Player;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (_started)
        {
            time += Time.deltaTime;
            time_text.text = "время прохождения: " + (int)time + " Секунд";
        }
    }

    public void start_finish()
    {
        _started = !_started;
    }
}
