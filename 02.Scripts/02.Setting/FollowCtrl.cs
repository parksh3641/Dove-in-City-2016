using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowCtrl : MonoBehaviour {

    public enum FollowType
    {
        MoveTowards,
        Lerp
    }
    public FollowType Type = FollowType.MoveTowards;
    public AirCtrl ufo;
    public float Speed;
    public float MaxDistanceToGoal = 0.1f;

    private IEnumerator<Transform> _currentPoint;

    public void Start()
    {
        Speed = GameManager.bgspeed * 2.5f;
        if (ufo == null)
        {
            Debug.LogError("우주선이 할당되지 않았습니다", gameObject);
            return;
        }
        _currentPoint = ufo.GetPathEnumerator();
        _currentPoint.MoveNext();

        if (_currentPoint.Current == null)
            return;

        transform.position = _currentPoint.Current.position;
    }

    public void Update()
    {
        if (_currentPoint == null || _currentPoint.Current == null)
            return;

        if (Type == FollowType.MoveTowards)
            transform.position = Vector3.MoveTowards(transform.position, _currentPoint.Current.position, Time.deltaTime * Speed);
        else if (Type == FollowType.Lerp)
            transform.position = Vector3.Lerp(transform.position, _currentPoint.Current.position, Time.deltaTime * Speed);

        var distanceSquard = (transform.position - _currentPoint.Current.position).sqrMagnitude;
        if (distanceSquard < MaxDistanceToGoal * MaxDistanceToGoal)
            _currentPoint.MoveNext();
    }

}
