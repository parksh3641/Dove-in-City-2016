using UnityEngine;
using System.Collections;

public class WaveCtrl : MonoBehaviour {
    private float Speed;
    private bool Die = false;
    private int A;
    private int B;
    private float C;

    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    IEnumerator ModeCheck()
    {
        if (gameObject.transform.position.x < -4.5f)
        {
            A = Random.Range(0, 4);
            C = Random.Range(0.1f, 0.22f);
            transform.position = new Vector3(A, transform.position.y, transform.position.z);
            transform.localScale = new Vector3(C, C, transform.localScale.z);
            animator.enabled = true;
            StartCoroutine(AnimCheck());
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(ModeCheck());
    }
    IEnumerator AnimCheck()
    {
        yield return new WaitForSeconds(2f);
        animator.enabled = false;
    }

    void OnEnable()
    {
        Speed = GameManager.bgspeed * 1.25f;
        GameManager.PlayerDie += PlayerDie;
        GameManager.PlayerLive += PlayerLive;
        A = Random.Range(4, -4);
        C = Random.Range(0.1f, 0.22f);
        transform.position = new Vector3(A, transform.position.y, transform.position.z);
        transform.localScale = new Vector3(C, C, transform.localScale.z);

        animator.enabled = true;

        StartCoroutine(AnimCheck());
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        GameManager.PlayerLive -= PlayerLive;

        StopAllCoroutines();
    }

    void PlayerDie()
    {
        Die = true;
    }
    void PlayerLive()
    {
        Die = false;
    }

    void Update()
    {
        if (Die == false)
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
    }
}
