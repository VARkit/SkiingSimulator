using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class FinishStatistic : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI time_text;
    public StartTimer timer;
    public bool finished;
    public PlayerMove Move;
    public float collisions;
    public TextMeshProUGUI collision_text;
    public TextMeshProUGUI Win_Or_Lose;
    public Image Panel;
    public AudioSource Sound;
    public AudioSource Ambient;
    public AudioClip lose;


    void Update()
    {
        if (timer.canvas.activeSelf == false)
        {
            if (!finished)
            {
                time += Time.deltaTime;
            }
            if (finished)
            {
                if (collisions > 0)
                {
                    Win_Or_Lose.text = "Вы проиграли!";
                }
                else
                {
                    Win_Or_Lose.text = "Вы выиграли!";
                }

                Ambient.volume = 0.05f;
                Panel.gameObject.SetActive(true);
                time_text.text = $"{(Math.Round(time, 2)).ToString()} секунд";
                collision_text.text = collisions.ToString();
                Move.tormoz = true;

                //if (collisions == 0)
                //{
                //int minutes = Int32.Parse(time.ToString().Split(":")[0]);
                //int seconds = Int32.Parse(time.ToString().Split(":")[1]);
                //Stat.StampToStat(minutes * 60 + seconds);
                //}

                //Stat.ViewStat(BestTimeText);
            }
        }
    }
}
