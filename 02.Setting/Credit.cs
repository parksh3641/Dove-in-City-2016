using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {
    public float speed = 0.01f;
    public GameObject Label;


    public delegate void credit();
    public static event credit Finish;
    void Start()
    {
        Label.transform.localPosition = new Vector3(0, -640, 0);
    }
    void Update()
    {
        Label.transform.Translate(0, speed * Time.deltaTime, 0);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Label.transform.localPosition = new Vector3(0, -640, 0);
            Finish();
            gameObject.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Label.transform.localPosition = new Vector3(0, -640, 0);
            Finish();
            gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Label.transform.localPosition = new Vector3(0, -640, 0);
            Finish();
            gameObject.SetActive(false);
        }

        if (Label.transform.localPosition.y > 650f)
        {
            Label.transform.localPosition = new Vector3(0, -640, 0);
            Finish();
            gameObject.SetActive(false);
        }
    }
}
