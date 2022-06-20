using UnityEngine;
using System.Collections;

public class TutorialStone : MonoBehaviour {
    public float speed = 0.9f;
    private Transform Player;
    private Transform Target;
    private int Dove;

    void OnEnable()
    {
        Player = GameObject.Find("ScoreObject").GetComponent<Transform>();
        Dove = PlayerPrefs.GetInt("Dove", 0);
        if (Dove == 0)
        {
            Target = GameObject.FindWithTag("Black").GetComponent<Transform>();
        }
        else if (Dove == 1)
        {
            Target = GameObject.FindWithTag("White").GetComponent<Transform>();
        }
        Vector2 relativePos = Player.transform.position - transform.position;
        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
        StartCoroutine(DeadTime());
    }
    void OnDisable()
    {
        StopAllCoroutines();
    }
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
    IEnumerator DeadTime()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
