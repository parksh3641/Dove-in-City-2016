using UnityEngine;
using System.Collections;

public class ScoreCtrl : MonoBehaviour {
    private float speed;

    //외부에서 오는 입력 받는곳
    void OnEnable()
    {
        GameManager.ScoreValueA += ScoreValueA;
        GameManager.ScoreValueB += ScoreValueB;
        GameManager.ScoreValueC += ScoreValueC;
    }
    void OnDisable()
    {
        GameManager.ScoreValueA -= ScoreValueA;
        GameManager.ScoreValueB -= ScoreValueB;
        GameManager.ScoreValueC -= ScoreValueC;

        StopAllCoroutines();
    }
    void ScoreValueA()
    {
        StartCoroutine(ModecheckA());
    }
    void ScoreValueB()
    {
        StartCoroutine(ModecheckB());
    }
    void ScoreValueC()
    {
        StartCoroutine(ModecheckC());
    }
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
    IEnumerator ModecheckA()
    {
        speed = GameManager.bgspeed + 0.1f;
        yield return new WaitForSeconds(0.7f);
        gameObject.SetActive(false);
    }
    IEnumerator ModecheckB()
    {
        speed = GameManager.bgspeed * 1.75f;
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
    IEnumerator ModecheckC()
    {
        speed = 0.2f;
        yield return new WaitForSeconds(0.7f);
        gameObject.SetActive(false);
    }
}
