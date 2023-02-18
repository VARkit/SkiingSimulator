using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class FinishStatistic : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI time_text;
    public TextMeshProUGUI time_textSecond;
    public StartTimer timer;
    public bool finished;
    public PlayerMove Move;
    public float collisions;
    public float collisionsSecond;
    public TextMeshProUGUI collision_text;
    public TextMeshProUGUI collision_textSecond;
    public TextMeshProUGUI Who_Win_Lose;
    public Image Panel;
    public AudioSource Ambient;
    public NET_FinishCollision NET_FinishCollision;
    public AudioSource Sound;
    public AudioClip lose;
    public FinStatSync FinStatSync;
    void Update()
    {
        if (timer.canvas.activeSelf == false)
        {
            if (!finished)
            {
                time += Time.deltaTime;
            }
            if (NET_FinishCollision.ColFinished == 2)
            {   
                if (FinStatSync.colFirstPrev != 0 && FinStatSync.ColSecondPrev != 0)
                {
                    FinStatSync.WhoWin_net = "Никто не победил. оба игрока сбили 1 и более флажков";
                }
                else if (FinStatSync.ColSecondPrev > FinStatSync.colFirstPrev && FinStatSync.TimeSecondPrev > FinStatSync.timeFirstPrev)
                {
                    FinStatSync.WhoWin_net = "Победил игрок справа!";
                }
                else
                {
                    FinStatSync.WhoWin_net = "Победил игрок слева!";
                }
                Ambient.volume = 0.05f;
                Panel.gameObject.SetActive(true);
                collision_text.text = FinStatSync.colFirst.ToString();
                Who_Win_Lose.text = FinStatSync.WhoWin_net_prev;
               // collision_textSecond.text = FinStatSync.ColSecondPrev.ToString();
                time_text.text = $"{(Math.Round(FinStatSync.timeFirstPrev, 2)).ToString()} секунд";
                //   time_textSecond.text = FinStatSync.TimeSecondPrev.ToString();
                finished = true;
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
