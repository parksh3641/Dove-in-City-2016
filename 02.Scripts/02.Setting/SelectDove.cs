using UnityEngine;
using System.Collections;

public class SelectDove : MonoBehaviour {
    private UISprite sprite;
    private Transform tr;
    public GameObject Talkbar;

    private BoxCollider box;

    public UIAtlas Black;
    public UIAtlas Eagle;
    public UIAtlas Dori;

    public float cooltime = 0.05f;
    private int Dove = 0;
    private int UNIT;
    public int A = 0;
    private int count = 0;
    private bool Count = false;

    private int Touchdove;

    private AudioSource source;
    public AudioClip Oha;

    public delegate void selectDove();
    public static event selectDove TouchDove;
    void Awake () {
        Talkbar.SetActive(false);
        Touchdove = PlayerPrefs.GetInt("Touchdove", 0);
        if (A ==1)
        {
            source = GetComponent<AudioSource>();
        }
        sprite = GetComponent<UISprite>();
        tr = GetComponent<Transform>();
        box = GetComponent<BoxCollider>();
    }
    void OnClick()
    {
        count += 1;
        if (Count == false)
        {
            source.PlayOneShot(Oha, 0.75f);
        }
        else
        {
            source.PlayOneShot(Oha, 1.5f);
        }

        if (cooltime > 0.03f)
        {
            cooltime -= 0.001f;
        }
        else
        {
            cooltime = 0.03f;
        }
        TouchDove();
        Touchdove += 1;
        PlayerPrefs.SetInt("Touchdove", Touchdove);

        UNIT = PlayerPrefs.GetInt("UNIT", 0);
        UNIT += 1;
        PlayerPrefs.SetInt("UNIT", UNIT);

        if (count >= 110)
        {
            if(Count == false)
            {
                Count = true;
                StartCoroutine(EasterEgg());
            }
        }
    }
    IEnumerator EasterEgg()
    {
        Talkbar.SetActive(true);
        yield return new WaitForSeconds(3f);
        Talkbar.SetActive(false);
    }
    void OnEnable()
    {
        Select.DoveOne += DoveOne;
        Select.DoveTwo += DoveTwo;
        Select.DoveThree += DoveThree;
        Select.DoveFour += DoveFour;
        Select.DoveFive += DoveFive;

        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            sprite.atlas = Black;
            StartCoroutine(black());
            box.size = new Vector3(100, 95, 0);
            gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
        }
        else if (Dove == 1)
        {
            sprite.atlas = Black;
            StartCoroutine(white());
            box.size = new Vector3(100, 95, 0);
            gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
        }
        else if (Dove == 2)
        {
            sprite.atlas = Eagle;
            StartCoroutine(eagle());
            tr.localPosition = new Vector3(20, 40, 0);
            tr.localScale = new Vector3(1.4f, 1.4f, 1);
            box.size = new Vector3(100, 95, 0);
            box.center = new Vector3(0, -0.5f, 0);
            gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
        }
        else if (Dove == 3)
        {
            sprite.atlas = Dori;
            StartCoroutine(dori());
            tr.localPosition = new Vector3(1, 36.5f, 0);
            tr.localScale = new Vector3(1.3f, 2.4f, 1);
            box.size = new Vector3(100, 67, 0);
            box.center = new Vector3(0, -16f, 0);
            gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
        }
        else if(Dove ==4)
        {
            sprite.atlas = Black;
            StartCoroutine(black());
            box.size = new Vector3(100, 95, 0);
            gameObject.GetComponent<UISprite>().color = new Color(0, 0, 0, 255);
        }
    }
    void OnDisable()
    {
        Select.DoveOne -= DoveOne;
        Select.DoveTwo -= DoveTwo;
        Select.DoveThree -= DoveThree;
        Select.DoveFour -= DoveFour;
        Select.DoveFive -= DoveFive;
    }
    void DoveOne()
    {
        StopAllCoroutines();
        sprite.atlas = Black;
        StartCoroutine(black());
        tr.localPosition = new Vector3(0, 40, 0);
        tr.localScale = new Vector3(1, 1, 1);
        box.size = new Vector3(100, 95, 0);
        box.center = new Vector3(0, 0, 0);
        gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
    }
    void DoveTwo()
    {
        StopAllCoroutines();
        sprite.atlas = Black;
        StartCoroutine(white());
        tr.localPosition = new Vector3(0, 40, 0);
        tr.localScale = new Vector3(1, 1, 1);
        box.size = new Vector3(100, 95, 0);
        box.center = new Vector3(0, 0, 0);
        gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
    }
    void DoveThree()
    {
        StopAllCoroutines();
        sprite.atlas = Eagle;
        StartCoroutine(eagle());
        tr.localPosition = new Vector3(20, 40, 0);
        tr.localScale = new Vector3(1.4f, 1.4f, 1);
        box.size = new Vector3(100, 67, 0);
        box.center = new Vector3(0, -16f, 0);
        gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
    }
    void DoveFour()
    {
        StopAllCoroutines();
        sprite.atlas = Dori;
        StartCoroutine(dori());
        tr.localPosition = new Vector3(1, 36.5f, 0);
        tr.localScale = new Vector3(1.3f, 2.4f, 1);
        box.size = new Vector3(80, 40, 0);
        box.center = new Vector3(0, -0.5f, 0);
        gameObject.GetComponent<UISprite>().color = new Color(255, 255, 255, 255);
    }
    void DoveFive()
    {
        StopAllCoroutines();
        sprite.atlas = Black;
        StartCoroutine(black());
        tr.localPosition = new Vector3(0, 40, 0);
        tr.localScale = new Vector3(1, 1, 1);
        box.size = new Vector3(100, 95, 0);
        box.center = new Vector3(0, 0, 0);
        gameObject.GetComponent<UISprite>().color = new Color(0, 0, 0, 255);
    }
    IEnumerator black()
    {
        sprite.spriteName = "black_1";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_2";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_6";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "black_2";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(black());
    }
    IEnumerator white()
    {
        sprite.spriteName = "White_1";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_2";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_6";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "White_2";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(white());
    }
    IEnumerator eagle()
    {
        sprite.spriteName = "Eagle1";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle2";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle6";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle5";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle4";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle3";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "Eagle2";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(eagle());
    }
    IEnumerator dori()
    {
        sprite.spriteName = "a";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "b";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "c";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "d";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "e";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "f";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "e";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "d";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "c";
        yield return new WaitForSeconds(cooltime);
        sprite.spriteName = "b";
        yield return new WaitForSeconds(cooltime);
        StartCoroutine(dori());
    }
}
