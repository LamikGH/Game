using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBricks : MonoBehaviour
{
    public List<Color> stateColors = new List<Color>();
    public List<Color> answerColors = new List<Color>();

    void Start() 
    {
        answerColors.Add(Color.white);
        answerColors.Add(Color.white);
        answerColors.Add(Color.white);
    }

    public void AddToState(Color color)
    {
        stateColors.Add(color);
    }

    public void AddToAnswer(Color color, int pos)
    {
        answerColors[pos] = color;
        Check();
    }

    public void Check()
    {
        bool result = true;

        for (int i = 0; i < stateColors.Count; i++)
        {
            if(answerColors[i] != stateColors[i])
            {
                result = false;
                break;
            }
        }

        if (result)
        {
            
        }
    }
}