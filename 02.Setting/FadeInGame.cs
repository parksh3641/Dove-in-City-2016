using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FadeInGame : MonoBehaviour {
    public GameObject M_Fade; //블랙
    public UISprite m_Fade;

    public GameObject R_Fade; //레드
    public GameObject r_Fade;

    private float EagleTime = 0;
    public float m_fDuration = 3.0f;

    void Awake()
    {
        M_Fade.SetActive(true);
        R_Fade.SetActive(false);
    }
    void Start()
    {
        StartCoroutine(FadeIn());
        EagleTime = GameManager.EagleTime;
    }
    void OnEnable()
    {
        PlayerCtrl.CastleIn += CastleIn;
        PlayerCtrl.CastleOut += CastleOut;
        PlayerCtrl.EagleTouch += EagleTouch;

        Talk.UnderWorld += UnderWorld;
        PlayerCtrl.UnderOut += UnderOut;
    }
    void OnDisable()
    {
        PlayerCtrl.CastleIn -= CastleIn;
        PlayerCtrl.CastleOut -= CastleOut;
        PlayerCtrl.EagleTouch -= EagleTouch;

        Talk.UnderWorld -= UnderWorld;
        PlayerCtrl.UnderOut -= UnderOut;
    }
    void CastleIn()
    {
        m_fDuration = 1.0f;
        StartCoroutine(FadeOut());
    }
    void CastleOut()
    {
        m_fDuration = 4f;
        StartCoroutine(FadeOut());
    }

    void UnderWorld()
    {
        m_fDuration = 1.0f;
        StartCoroutine(FadeOut());
    }
    void UnderOut()
    {
        m_fDuration = 4f;
        StartCoroutine(FadeOut());
    }
    void EagleTouch()
    {
        r_Fade.SetActive(true);
        StartCoroutine(Eagletime());
    }
    IEnumerator Eagletime()
    {
        R_Fade.SetActive(true);
        yield return new WaitForSeconds(EagleTime);
        R_Fade.SetActive(false);
    }
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.1f);
        TweenAlpha.Begin(m_Fade.gameObject, m_fDuration, 0.0f);
        yield return new WaitForSeconds(m_fDuration);
    }
    IEnumerator FadeOut()
    {
        // Fade Out
        TweenAlpha.Begin(m_Fade.gameObject, m_fDuration-1.0f, 1.0f);
        yield return new WaitForSeconds(m_fDuration-1.0f);
        m_fDuration = 3.0f;
        StartCoroutine(fadeIn());
    }
    IEnumerator fadeIn()
    {
        yield return new WaitForSeconds(0.1f);
        TweenAlpha.Begin(m_Fade.gameObject, m_fDuration, 0.0f);
        yield return new WaitForSeconds(m_fDuration);
    }
}
