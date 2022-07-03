using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {
    public UISprite m_Fade;
    public float m_fDuration = 3.0f;

    public GameObject MainUI;
    public GameObject SurUI;
    public GameObject StartUI;
    public GameObject startui;
    public GameObject NotionUI;

    public GameObject Logo1;
    public GameObject Logo2;
    public GameObject Logo3;
    public GameObject Background;

    private AudioSource source;
    public AudioClip Water;
    public AudioClip Shot1;
    public AudioClip Shot2;
    public AudioClip Coin;
    public AudioClip Click;
    public AudioSource MainSong;

    private int Tutorial;

    void Start()
    {
        Tutorial = PlayerPrefs.GetInt("Tutorial", 0);
        Logo1.SetActive(false);
        Logo2.SetActive(false);
        Logo3.SetActive(false);
        Background.SetActive(false);
        MainUI.SetActive(true);
        SurUI.SetActive(false);
        StartUI.SetActive(false);
        NotionUI.SetActive(false);
        m_Fade.enabled = true;
        source = GetComponent<AudioSource>();
        source.PlayOneShot(Water, 1.0f);
        StartCoroutine(FadeIn());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.1f);
        TweenAlpha.Begin(m_Fade.gameObject, m_fDuration, 0.0f);
        yield return new WaitForSeconds(m_fDuration);
        StartCoroutine(LogoStart());
    }
    IEnumerator LogoStart()
    {
        yield return new WaitForSeconds(0.8f);
        source.Stop();
        MainUI.SetActive(false);
        SurUI.SetActive(true);
        Background.SetActive(true);
        Logo1.SetActive(true);
        source.PlayOneShot(Shot2, 0.75f);
        yield return new WaitForSeconds(0.6f);
        Logo2.SetActive(true);
        source.PlayOneShot(Shot2, 0.75f);
        yield return new WaitForSeconds(0.6f);
        Logo3.SetActive(true);
        source.PlayOneShot(Shot1, 1f);
        MainSong.Play();
        yield return new WaitForSeconds(0.8f);
        StartUI.SetActive(true);
        StartCoroutine(UISetting());
    }
    IEnumerator UISetting()
    {
        startui.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        startui.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(UISetting());
    }
    IEnumerator FadeOut()
    {
        // Fade Out
        TweenAlpha.Begin(m_Fade.gameObject, m_fDuration-1.0f, 1.0f);
        yield return new WaitForSeconds(m_fDuration-1.0f);
        NextSceneCall();
    }
    void NextSceneCall()
    {
        if(Tutorial ==0)
        {
            PlayerPrefs.SetString("Scene", "TutorialScene");
        }
        else
        {
            PlayerPrefs.SetString("Scene", "MainScene");
        }

        SceneManager.LoadScene("LoadScene");
    }
    public void Touch()
    {
        source.PlayOneShot(Coin, 0.75f);
        StopAllCoroutines();
        source.PlayOneShot(Coin, 0.75f);
        StartCoroutine(FadeOut());
    }
}
