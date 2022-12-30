using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnswer : MonoBehaviour
{
    public Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow, Color.black };

    private int index = 0;
    public int pos;

    public GameObject colorBlocks;
    private StateBricks state;

    void Start()
    {
        state = colorBlocks.GetComponent<StateBricks>();
    }

    public void Activate()
    {
        if (index > 4)
        {
            index = 0;
        }
        GetComponent<Renderer>().material.color = colors[index];
        state.AddToAnswer(colors[index], pos);
        index++;
    }
}
