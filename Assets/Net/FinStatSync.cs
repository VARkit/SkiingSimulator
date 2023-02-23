using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FinStatSync : RealtimeComponent<FinColSyncModel>
{

    public string WhoWin_net;
    public string WhoWin_net_prev;
    public float timeFirst;
    public float timeFirstPrev;
    public float TimeSecond;
    public float TimeSecondPrev;
    public float colFirst;
    public float colFirstPrev;
    public float ColSecond;
    public float ColSecondPrev;

    public void Update()
    {
        GetComponent<FinStatSync>().SetValues(WhoWin_net, timeFirst, TimeSecond, colFirst, ColSecond);
        WhoWin_net_prev = WhoWin_net;
        timeFirstPrev = timeFirst;
        TimeSecondPrev = TimeSecond;
        colFirstPrev = colFirst;
        ColSecondPrev = ColSecond;
    }
    private void UpdateWinnerValue()
    {
        WhoWin_net = model.whowinner;
    }
    private void UpdateTime1Value()
    {
        timeFirst = model.timeFirst;
    }
    private void UpdateTime2Value()
    {
        TimeSecond = model.timeSecond;
    }
    private void UpdateCol1Value()
    {
        colFirst = model.colFirst;
    }
    private void UpdateCol2Value()
    {
        ColSecond = model.colSecond;
    }

    protected override void OnRealtimeModelReplaced(FinColSyncModel previousModel, FinColSyncModel currentModel)
    {
        if(previousModel != null)
        {
            previousModel.whowinnerDidChange -= WhowinDidChange;
            previousModel.timeFirstDidChange -= Time1DidChange;
            previousModel.colFirstDidChange -= Col1DidChange;
            previousModel.timeSecondDidChange -= Time2DidChange;
            previousModel.colSecondDidChange -= Col2DidChange;
        }
        if (currentModel != null)
        {
            if (currentModel.isFreshModel)
            {
                currentModel.whowinner = WhoWin_net;
                currentModel.timeFirst = timeFirstPrev;
                currentModel.timeSecond = TimeSecondPrev;
                currentModel.colFirst = colFirstPrev;
                currentModel.colSecond = ColSecondPrev;
            }

            UpdateWinnerValue();
            UpdateTime1Value();
            UpdateTime2Value();
            UpdateCol1Value();
            UpdateCol2Value();
            currentModel.whowinnerDidChange += WhowinDidChange;
            currentModel.timeFirstDidChange += Time1DidChange;
            currentModel.timeSecondDidChange += Time2DidChange;
            currentModel.colFirstDidChange += Col1DidChange;
            currentModel.colSecondDidChange += Col2DidChange;
        }
    }
    private void WhowinDidChange(FinColSyncModel model, string value)
    {
        UpdateWinnerValue();
    }
    private void Time1DidChange(FinColSyncModel model, float value)
    {
        UpdateTime1Value();
    }
    private void Time2DidChange(FinColSyncModel model, float value)
    {
        UpdateTime2Value();
    }
    private void Col1DidChange(FinColSyncModel model, float value)
    {
        UpdateCol1Value();
    }
    private void Col2DidChange(FinColSyncModel model, float value)
    {
        UpdateCol2Value();
    }
    public void SetValues(string winner, float time1, float time2, float col1, float col2)
    {
        model.whowinner = winner;
        model.timeFirst = time1;
        model.timeSecond = time2;
        model.colFirst = col1;
        model.colSecond = col2;
    }


}
