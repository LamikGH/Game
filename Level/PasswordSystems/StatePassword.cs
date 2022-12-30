using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatePassword : MonoBehaviour
{
    public GameObject door;
    private string password;
    public TextMeshPro passwordCode;
    public string inputPassword;

    void Start()
    {
        CreatePassword();
    }

    void CreatePassword()
    {
        password = Random.Range(1000,9999).ToString();
        passwordCode.text = password;
    }

    public void CheckPassword()
    {
        if (inputPassword == password)
        {
            Destroy(door);
        }
        else
        {
            inputPassword = "";
        }
    }

    public void ResetPassword()
    {
        inputPassword = "";
    }

    public void Event(string name) 
    {
        if(name == "green")
        {
            CheckPassword();
        }
        else if (name == "red")
        {
            ResetPassword();
        }
        else
        {
            inputPassword += name;
        }
    }
}
