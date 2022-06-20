using UnityEngine;
using System.Collections;

public class StoneCtrl : MonoBehaviour {

    private Transform Player; //좀 위에 있는거
    private Transform Target;

    private int Dove;
    private int Magnet = 0;
    private int magnet;

    private float speed;
    public float posx;
    public float posy;
    private float A;
    private float B;
    private Vector3 distance;
    void Awake()
    {
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Target = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Target = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Target = GameObject.FindWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Target = GameObject.FindWithTag("Dori").GetComponent<Transform>();
        }
    }
    void OnEnable()
    {
        speed = GameManager.bgspeed * 1.6f;
        Player = GameObject.FindWithTag("Target").GetComponent<Transform>();
        Vector2 relativePos = Player.transform.position - transform.position;
        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
        StartCoroutine(DeadTime());
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator ModeCheck()
    {
        Magnet = PlayerPrefs.GetInt("Magnet", 0);
        if (Magnet == 0)
        {
            magnet = 0;
        }
        else if (Magnet ==1)
        {
            magnet = 1;
        }
        else if(Magnet == 2)
        {
            magnet = 2;
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
    void Update()
    {
        if(magnet == 0)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else if (magnet == 1)
        {
            if(gameObject.tag == "ManDu")
            {
                Vector2 relativePos = Target.transform.position - transform.position;
                float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
                transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
                transform.Translate(transform.up * speed * 2f * Time.deltaTime, Space.World);
            }
            else if(gameObject.tag == "Stone")
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
        else if(magnet ==2)
        {
            if (gameObject.tag == "Stone")
            {
                Vector2 relativePos = Target.transform.position - transform.position;
                float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
                transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
                transform.Translate(transform.up * speed * 2f * Time.deltaTime, Space.World);
            }
            else if (gameObject.tag == "ManDu")
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
    }
    IEnumerator DeadTime()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
