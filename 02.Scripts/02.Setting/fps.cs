using UnityEngine;
using System.Collections;

public class fps : MonoBehaviour
{
	float deltaTime = 0.0f;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(-10, h-h*0.05f, w, h * 0.02f);
        style.alignment = TextAnchor.UpperRight;
        style.fontSize = h * 3 / 100;
        style.normal.textColor = Color.black;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
}