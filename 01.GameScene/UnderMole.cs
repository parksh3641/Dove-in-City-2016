using UnityEngine;
using System.Collections;

public class UnderMole : MonoBehaviour {
    private Animator animator;
    private float CoolTime;
    private int A;
    void Awake()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }
    void OnEnable()
    {
        CoolTime = Random.Range(0, 4.0f);
        StartCoroutine(ModeCheck());
    }
    void OnDisable()
    {
        animator.enabled = false;
        StopAllCoroutines();
    }
    IEnumerator ModeCheck()
    {
        yield return new WaitForSeconds(CoolTime);
        animator.enabled = true;
    }
}
