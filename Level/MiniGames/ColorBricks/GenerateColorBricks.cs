using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateColorBricks : MonoBehaviour
{
    public GameObject QuestionBrick1;
    public GameObject QuestionBrick2;
    public GameObject QuestionBrick3;

    public Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow, Color.black };

    public StateBricks state;


    void Start()
    { 
        state = gameObject.GetComponentInParent<StateBricks>();

        Color stateColor = colors[Random.Range(0, 4)];
        QuestionBrick1.GetComponent<Renderer>().material.color = stateColor;
        state.AddToState(stateColor);

        Color stateColor2 = colors[Random.Range(0, 4)];
        QuestionBrick2.GetComponent<Renderer>().material.color = stateColor2;
        state.AddToState(stateColor2);

        Color stateColor3 = colors[Random.Range(0, 4)];
        QuestionBrick3.GetComponent<Renderer>().material.color = stateColor3;
        state.AddToState(stateColor3);
    }


}
