using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Start : RealtimeComponent<Start_Networking>
{

    public int Touch_count;
    public int Prev;

    public void Update()
    {
            if(Prev != Touch_count)
            {
                GetComponent<Start>().SetValue(Touch_count);
                Prev = Touch_count;
            }
            
            

    }
    private void UpdateIntValue()
    {
        Touch_count = model.touchcount;
    }
    protected override void OnRealtimeModelReplaced(Start_Networking previousModel, Start_Networking currentModel)
    {
        if(previousModel != null)
        {
            previousModel.touchcountDidChange -= CounterDidChange;
        }
        if(currentModel != null)
        {
            if (currentModel.isFreshModel)
            {
                currentModel.touchcount = Touch_count;
            }

            UpdateIntValue();

            currentModel.touchcountDidChange += CounterDidChange; 
        }
    }
    private void CounterDidChange(Start_Networking model, int value)
    {
        UpdateIntValue();
    }
    private void SetValue(int value)
    {
        model.touchcount = value;
    }
    public void plusCount()
    {
        Touch_count++;
    }

}
