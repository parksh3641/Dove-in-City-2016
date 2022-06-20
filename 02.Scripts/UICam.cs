using UnityEngine;
using System.Collections;

public class UICam : MonoBehaviour {

    public Transform A;
    public Transform Panel;

    public Camera B;

    private float Cam;

    void Start()
    {
        B = GetComponent<Camera>();
        A = Camera.main.GetComponent<Transform>();
    }
    void LateUpdate()
    {
        Cam = FollowCam.Cam;

        B.orthographicSize = Cam;

        transform.position = A.position;
    }
}
