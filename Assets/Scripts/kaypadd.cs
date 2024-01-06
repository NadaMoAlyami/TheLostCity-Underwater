using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Meta.WitAi;

public class kaypadd : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;  
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject ClearButton;
    public GameObject EnterButton;

    public void b1()
    {
        charHolder.text = charHolder.text + "C";

    }
    public void b2()
    {
        charHolder.text = charHolder.text + "O";

    }
    public void b3()
    {
        charHolder.text = charHolder.text + "N";

    }
    public void b4()
    {
        charHolder.text = charHolder.text + "E";

    }
    public void b5()
    {
        charHolder.text = charHolder.text + "S";

    }

    public void b6()
    {
        charHolder.text = charHolder.text + "3";

    }
    public void b7()
    {
        charHolder.text = charHolder.text + "*";

    }

    public void clearEvent()
    {
        charHolder.text = null;

    }

    public void enterEvent()
    {
        if(charHolder.text == "OCENS*3")
        {
            Debug.Log("Success");

        }
        else
        {
            Debug.Log("Faild");
        }
    }
}
