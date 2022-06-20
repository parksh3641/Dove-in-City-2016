using UnityEngine;
using System.Collections;

public class EggCtrl : MonoBehaviour {
    private float speed;

    private int Dove;
    private float distance;
    private Transform Player;

    void OnEnable()
    {
        speed = GameManager.bgspeed * 3f;
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Player = GameObject.FindGameObjectWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Player = GameObject.FindGameObjectWithTag("White").GetComponent<Transform>();
        }
        else if (Dove == 2)
        {
            Player = GameObject.FindGameObjectWithTag("Eagle").GetComponent<Transform>();
        }
        else if (Dove == 3)
        {
            Player = GameObject.FindGameObjectWithTag("Dori").GetComponent<Transform>();
        }

        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        StopAllCoroutines();
    }
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
    IEnumerator ModeCheck()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (distance > 1.4f)
        {
            gameObject.SetActive(false);
        }
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(ModeCheck());
    }
}
