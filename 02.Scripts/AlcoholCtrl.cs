using UnityEngine;
using System.Collections;

public class AlcoholCtrl : MonoBehaviour {
    private float speed;
    public int Which = 0;
    private int Cooltime;
    private bool wait = false;
    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void OnEnable()
    {
        speed = GameManager.bgspeed;
        GameManager.PlayerDie += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        StartCoroutine(RandomVector());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        StopAllCoroutines();
    }
    void PlayerDie()
    {
        speed = 0;
        animator.enabled = false;
    }
    void PlayerLive()
    {
        speed = GameManager.bgspeed;
        animator.enabled = true;
    }
    IEnumerator RandomVector()
    {
        Cooltime = Random.Range(4, 6);
        if(wait == false)
        {
            Which = Random.Range(1, 9);
        }
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(RandomVector());
    }
    void Update()
    {
        if (Which == 1)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else if (Which == 2)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Which == 3)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Which == 4)
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        else if (Which == 5)
        {
            transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
        }
        else if (Which == 6)
        {
            transform.Translate(speed * Time.deltaTime, -speed * Time.deltaTime, 0);
        }
        else if (Which == 7)
        {
            transform.Translate(-speed * Time.deltaTime, speed * Time.deltaTime, 0);
        }
        else if (Which == 8)
        {
            transform.Translate(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Road")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "Building")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "SeaStart")
        {
            Trigger();
        }
    }
    void Trigger()
    {
        if (Which == 1)
        {
            Which = 4;
        }
        else if (Which == 2)
        {
            Which = 3;
        }
        else if (Which == 3)
        {
            Which = 2;
        }
        else if (Which == 4)
        {
            Which = 1;
        }

        else if (Which == 5)
        {
            Which = 8;
        }
        else if (Which == 6)
        {
            Which = 7;
        }
        else if (Which == 7)
        {
            Which = 6;
        }
        else if (Which == 8)
        {
            Which = 5;
        }
        StopCoroutine("waitTime");
        StartCoroutine("waitTime");
    } //반대방향으로 밀어내기
    IEnumerator waitTime()
    {
        wait = true;
        yield return new WaitForSeconds(1f);
        wait = false;
    }
}
