using UnityEngine;
using System.Collections;

public class TutorialTouch : MonoBehaviour {
    public GameObject Bird;
    public Transform A;

    private int posx = 360;
    private int posy = 640;

    public float speed = 0.6f;

    private bool start = false;
    void Start()
    {
        Screen.SetResolution(posx, posy, true);
        A = Bird.transform;
    }

    void OnEnable()
    {
        TutorialManager.go += GameStart;
        TutorialManager.stop += GameStop;
    }
    void OnDisable()
    {
        TutorialManager.go -= GameStart;
        TutorialManager.stop -= GameStop;
    }

    void GameStart()
    {
        start = true;
    }
    void GameStop()
    {
        start = false;
    }

    void Update()
    {
        if (start == true)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 pos = touch.position;

                if (pos.y > posx * 0.2f) //맨 밑 20% 터치금지
                {
                    if (pos.x >= posx * 0.5f) //오른쪽
                    {
                        A.transform.Translate(speed * Time.deltaTime, 0, 0);
                    }
                    else //왼쪽
                    {
                        A.transform.Translate(-speed * Time.deltaTime, 0, 0);

                    }
                }
            }
        }
    }
}
