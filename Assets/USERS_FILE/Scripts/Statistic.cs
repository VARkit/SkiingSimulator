using UnityEngine;
using System.IO;
using TMPro;
using System;

public class Statistic : MonoBehaviour
{
    public int BestTime = 9999999;
    public void StampToStat(int Time)
    {
        Directory.CreateDirectory(Application.streamingAssetsPath + "/Logs/");

        string txtDocumentName = Application.streamingAssetsPath + "/Logs/" + "RaceHstory" + ".txt";
        if (Time < BestTime){
            BestTime = Time;
            File.Delete(txtDocumentName);
            File.WriteAllText(txtDocumentName, $"{Math.Floor(Time / 60f)}:{Math.Floor(Time % 60f)}");
        }
    }

    public void ViewStat(TextMeshProUGUI TextOnCanvas)
    {
        TextOnCanvas.text = $"{Math.Floor(BestTime / 60f)}:{Math.Floor(BestTime % 60f)}";

        //    string Text = File.ReadAllText(Application.streamingAssetsPath + "/Logs/" + "RaceHstory" + ".txt");
        //    string[] Times = new string[Text.Split('\n').Length];
        //    Times = Text.Split("\n");
        //    int[] IntTimes = new int[Times.Length];

        //    foreach (string Time in Times)
        //    {
        //        int minutes = Int32.Parse(Time.Split(":")[0]);
        //        int seconds = Int32.Parse(Time.Split(":")[1]);
        //        IntTimes[Time.IndexOf(Time)] = minutes * 60 + seconds;
        //    }

        //    int[] SortIntTimes = new int[IntTimes.Length];
    }
}