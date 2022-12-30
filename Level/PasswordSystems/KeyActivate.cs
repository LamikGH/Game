using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivate : MonoBehaviour
{
    public StatePassword state;
    public string key;

    void Start()
    {
        state = gameObject.GetComponentInParent<StatePassword>();
        key = gameObject.name;
    }

    public void Activate()
    {
        state.Event(key);
    }
}
