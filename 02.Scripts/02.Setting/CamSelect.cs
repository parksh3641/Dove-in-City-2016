using UnityEngine;
using System.Collections;

public class CamSelect : MonoBehaviour {
    public float speed = 1.0f;
    public float Which = 10;
    private Transform cam;

    void Start()
    {
        cam = GetComponent<Transform>();
    }
    void OnEnable()
    {
        SelectDove.TouchDove += TouchDove;
    }
    void OnDisable()
    {
        SelectDove.TouchDove -= TouchDove;
    }
    void TouchDove()
    {
        if(speed < 0.7f)
        {
            speed += 0.01f;
        }
        else
        {
            speed = 0.6f;
        }
    }
    void Update()
    {
        cam.transform.Translate(-speed * Time.deltaTime, 0, 0);

        if(cam.transform.position.x < Which)
        {
            cam.position = new Vector3(0, transform.position.y, 0);
        }
    }
}
