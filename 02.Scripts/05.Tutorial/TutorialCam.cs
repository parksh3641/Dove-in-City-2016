using UnityEngine;
using System.Collections;

public class TutorialCam : MonoBehaviour
{
    public Transform Bird;
    private bool Cam = false;
    private float BirdWhich = 0.25f;

    public float movelimitx;
    public float movelimity;

    private float which =1;
    private bool CamUp = false;
    public GameObject Panel;
    void OnEnable()
    {
        TutorialManager.SkillUse += Skilluse;
    }
    void OnDisable()
    {
        TutorialManager.SkillUse -= Skilluse;
    }
    void Skilluse()
    {
        StartCoroutine(CamCooltime());
    }
    IEnumerator CamCooltime()
    {
        CamUp = true;
        StartCoroutine(SkillCam());
        yield return new WaitForSeconds(5);
        CamUp = false;
    }
    IEnumerator SkillCam()
    {
        if (CamUp == true)
        {
            which += 0.001f;
            GameManager.movelimitx += 0.0006f;
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(SkillCam());
        }
        else
        {
            if (which > 1)
            {
                which -= 0.001f;
                GameManager.movelimitx -= 0.0006f;
                yield return new WaitForSeconds(0.01f);
                StartCoroutine(SkillCam());
            }
            else
            {
                StopCoroutine(SkillCam());
            }

        }
    }

    public void BirdCheck(int A)
    {
        if (A == 0)
        {
            Bird = GameObject.FindGameObjectWithTag("Black").GetComponent<Transform>();
        }
        else
        {
            Bird = GameObject.FindGameObjectWithTag("White").GetComponent<Transform>();
        }
        Cam = true;
    }
    void LateUpdate()
    {
        Camera.main.orthographicSize = which;
        Panel.transform.localScale = new Vector3(which, which, 1);
        if (Cam == true)
        {
            transform.position = new Vector3(Bird.position.x, (Bird.position.y + BirdWhich), transform.position.z);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -movelimitx, movelimitx)
    , Mathf.Clamp(transform.position.y, -movelimity, movelimity), 0);
    }
}
