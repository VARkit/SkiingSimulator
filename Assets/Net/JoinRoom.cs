using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class JoinRoom : RealtimeComponent<JoinRoom_Network>
{

    public int connected_players;
    public int PreviousValue;
    public Transform[] SpawnPoints;
    public GameObject Avatar;

    public void Changed()
    {
        
            GetComponent<JoinRoom>().SetValue(connected_players);
            PreviousValue = connected_players;
            Avatar.transform.position = SpawnPoints[PreviousValue - 1].position;
        
            
    }
    private void UpdateIntValue()
    {
        connected_players = model.counter;
    }
    protected override void OnRealtimeModelReplaced(JoinRoom_Network previousModel, JoinRoom_Network currentModel)
    {
        if(previousModel != null)
        {
            previousModel.counterDidChange -= CounterDidChange;
        }
        if(currentModel != null)
        {
            if (currentModel.isFreshModel)
            {
                currentModel.counter = connected_players;
            }

            UpdateIntValue();

            currentModel.counterDidChange += CounterDidChange; 
        }
    }
    private void CounterDidChange(JoinRoom_Network model, int value)
    {
        UpdateIntValue();
    }
    public void SetValue(int value)
    {
        model.counter = value;
    }
}
