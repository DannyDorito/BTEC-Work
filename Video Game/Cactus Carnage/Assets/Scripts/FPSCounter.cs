using UnityEngine;
using System.Collections;

public class FPSCounter : MonoBehaviour
{
    float deltaTime = 0.0f;

    void Update() //Every frame, updastes frame counter
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }
    void OnGUI()
    {
        int w = Screen.width, h = Screen.height; //Gets screen size

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100); //Sets the size of the drawn rectangle
        style.alignment = TextAnchor.LowerRight; //Position of text
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f); //Colour of the text, dark blue
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps); //Shows frames per second, and delay in miliseconds
        GUI.Label(rect, text, style);
    }
}