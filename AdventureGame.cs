using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;


    State state;

    string[] oddNumbers = { "mon" , "tues", "wedn", "thurs" };
    

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(oddNumbers[2]);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextStates = state.GetNextStates();

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            textComponent.text = state.GetStateStory();
        }

        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            textComponent.text = state.GetStateStory();
        }

        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
            textComponent.text = state.GetStateStory();
        }
    }
}
