using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NET_FinishCollision : RealtimeComponent<Col_newwork>
{
    public int ColFinished;
    public int Prev;

    public void Update()
    {
        if (Prev != ColFinished)
        {
            GetComponent<NET_FinishCollision>().SetValue(ColFinished);
            Prev = ColFinished;
        }



    }
    private void UpdateIntValue()
    {
        ColFinished = model.finised;
    }
    protected override void OnRealtimeModelReplaced(Col_newwork previousModel, Col_newwork currentModel)
    {
        if (previousModel != null)
        {
            previousModel.finisedDidChange -= CounterDidChange;
        }
        if (currentModel != null)
        {
            if (currentModel.isFreshModel)
            {
                currentModel.finised = ColFinished;
            }

            UpdateIntValue();

            currentModel.finisedDidChange += CounterDidChange;
        }
    }
    private void CounterDidChange(Col_newwork model, int value)
    {
        UpdateIntValue();
    }
    private void SetValue(int value)
    {
        model.finised = value;
    }
    public void plusCount()
    {
        ColFinished++;
    }

}
