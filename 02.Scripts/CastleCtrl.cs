using UnityEngine;
using System.Collections;

public class CastleCtrl : MonoBehaviour {
    private float speed = 0.3f;

    public int Which = 0;
    private float Cooltime = 0;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        GameManager.GamePause += PlayerDie;
        GameManager.PlayerLive += PlayerLive;

        StartCoroutine(RandomVector());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.GamePause -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        animator.enabled = true;
        StopAllCoroutines();
    }
    void PlayerDie()
    {
        if(gameObject.activeInHierarchy == true)
        {
            animator.enabled = false;
            speed = 0;
            StopAllCoroutines();
        }
    }
    void PlayerLive()
    {
        if(gameObject.activeInHierarchy == true)
        {
            animator.enabled = true;
            speed = 0.3f;
            StartCoroutine(RandomVector());
        }
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
    }
    IEnumerator RandomVector()
    {
        Cooltime = Random.Range(3, 5);
        Which = Random.Range(1, 5);
        AnimCheck();
        yield return new WaitForSeconds(Cooltime);
        StartCoroutine(RandomVector());

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Road")
        {
            Trigger();
        }
        if (coll.gameObject.tag == "People")
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
        AnimCheck();
    } //반대방향으로 밀어내기
    void AnimCheck()
    {
        if (Which == 1)
        {
            animator.SetBool("back", true);
            animator.SetBool("front", false);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
        else if (Which == 2)
        {
            animator.SetBool("left", true);
            animator.SetBool("front", false);
            animator.SetBool("back", false);
            animator.SetBool("right", false);
        }
        else if (Which == 3)
        {
            animator.SetBool("right", true);
            animator.SetBool("front", false);
            animator.SetBool("left", false);
            animator.SetBool("back", false);
        }
        else if (Which == 4) //a 1증가
        {
            animator.SetBool("front", true);
            animator.SetBool("back", false);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
    }
}
