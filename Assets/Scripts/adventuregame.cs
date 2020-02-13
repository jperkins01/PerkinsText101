using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventuregame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    string[] daysOfTheWeek = { "mon", "tues", "Wed", "Thurs", "Friday" };

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(daysOfTheWeek[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
