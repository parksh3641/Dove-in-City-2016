using UnityEngine;
using System.Collections;

public class notion : MonoBehaviour {
    public float speed = 0.09f;
    public float cooltime = 0.2f;
    public float Alpha = 0.02f;
    public float Scale = 0.0006f;

    private Transform A;
    private UILabel uiLabel;
    private float alpha;
    private float scale;
    private bool B;
    public float Which;

    void Start()
    {
        A = GetComponent<Transform>();
        uiLabel = GetComponent<UILabel>();
    }
    void Update()
    {
        uiLabel.color = new Color(uiLabel.color.r, uiLabel.color.g, uiLabel.color.b, alpha);
        transform.localScale = new Vector3(scale, scale, 0);
        if (B ==false)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, speed * 0.25f * Time.deltaTime, 0);
        }
    }
	void OnEnable()
    {
        GameManager.PlayerDie += PlayerDie;
        alpha = 1.0f;
        scale = 1.0f;
        B = false;
        StartCoroutine(Wait());
        StartCoroutine(Up());
    }
    void OnDisable()
    {
        GameManager.PlayerDie -= PlayerDie;
        transform.localPosition = new Vector3(0, Which, 0);
    }
    void PlayerDie()
    {
        StopAllCoroutines();
        transform.localPosition = new Vector3(0, Which, 0);
        gameObject.SetActive(false);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(cooltime);
        B = true;
    }
    IEnumerator Down()
    {
        if(alpha > 0)
        {
            alpha -= Alpha;
            scale -= Scale;
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(Down());
        }
        else
        {
            transform.localPosition = new Vector3(0, Which, 0);
            gameObject.SetActive(false);
        }
    }
    IEnumerator Up()
    {
        if(B == false)
        {
            scale += Scale;
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(Up());
        }
        else
        {
            StopCoroutine(Up());
            StartCoroutine(Down());
        }
    }
}
