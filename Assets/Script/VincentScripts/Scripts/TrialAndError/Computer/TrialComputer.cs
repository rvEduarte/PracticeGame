using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Drawing;

public class TrialComputer : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletHelloWrite;
    public TMP_Text canvasText;

    string helloWriteLine = "HelloWorld";

    string a = null;
    string b = null;
    string c = null;

    int counter = 0;

    string TITE = null;
    string PEPE = null;
    string TEPE = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Person myObj = new Person();
        

        if (counter == 1)
        {
            Debug.Log("WLHELLO_COUNTER3");
            //canvasText.text = helloWriteLine;
            //counter++;

            if(a == "HELLOWORLD")
            {
                myObj.Name = "HELLOWORLD";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

            else if(a == "7")
            {
                myObj.Name = "7";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

            else if(a == "SPACE_HELLOWORLD")
            {
                myObj.Name = "\nHELLOWORLD";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

            else if (a == "SPACE_7")
            {
                myObj.Name = "\n7";
                string color = "#18eded";
                canvasText.text = "" + "<color=" + color + ">" + myObj.Name + "</color>";
                TITE = myObj.Name;
            }

        }
        if (counter == 2)
        {
            Debug.Log("WLHELLO_COUNTER2");
            if (a == "HELLOWORLD")
            {
                Debug.Log("KARL_TITE");
                myObj.Name1 = "HELLOWORLD";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
                //canvasText.text = "" + TITE + "<color=" + color + ">HELLOWORLD</color>";
            }

            else if(a == "7")
            {
                myObj.Name1 = "7";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
            }

            else if (a == "SPACE_HELLOWORLD")
            {
                myObj.Name1 = "\nHELLOWORLD";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
            }

            else if (a == "SPACE_7")
            {
                myObj.Name1 = "\n7";
                PEPE = myObj.Name1;
                //canvasText.color = Color.red;
                string color = "#18eded";
                canvasText.text = "" + TITE + "<color=" + color + ">" + PEPE + "</color>";
            }

        }
        if (counter == 3)
        {
            if (a == "HELLOWORLD")
            {
                myObj.Name2 = "HELLOWORLD";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";
            }

            else if (a == "7")
            {
                myObj.Name2 = "7";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";

            }

            else if (a == "SPACE_HELLOWORLD")
            {
                myObj.Name2 = "\nHELLOWORLD";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";
            }
            else if (a == "SPACE_7")
            {
                myObj.Name2 = "\n7";
                TEPE = myObj.Name2;
                //canvasText.color = Color.red;
                string color2 = "#03960f";
                string color = "#18eded";
                canvasText.text = "" + TITE + PEPE + "<color=" + color + ">" + TEPE + "</color>" + "<color=" + color2 + ">\n\n\n...Program finished with exit code 0</color>";
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ENTER BULLET TITE");
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject.tag == "WHELLO")
        {
            Debug.Log("ENTER W__HELLO");
            a = "HELLOWORLD";
            
            
            
            //b = "HELLOWORLD";
            //c = "HELLOWORLD";
            counter++;
            
        }
        else if(collision.gameObject.tag == "WLHELLO")
        {
            Debug.Log("ENTER WL__HELLO");
            a = "SPACE_HELLOWORLD";
            counter++;
        }

        else if (collision.gameObject.tag == "W7")
        {
            Debug.Log("ENTER W__7");
            a = "7";
            counter++;
        }

        else if (collision.gameObject.tag == "WL7")
        {
            Debug.Log("ENTER W__7");
            a = "SPACE_7";
            counter++;
        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("EXIT BULLET TITE");
        //if the game object we collided with is not equal to the current game object (so anything other than itself)
        if (collision.gameObject.tag == "WHELLO")
        {
            Debug.Log("EXIT W__HELLO");
            b = null;
            c = null;

        }
    }*/
}

class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }

    private string name1; // field
    public string Name1   // property
    {
        get { return name1; }
        set { name1 = value; }
    }
    private string name2;
    public string Name2   // property
    {
        get { return name2; }
        set { name2 = value; }
    }
}
