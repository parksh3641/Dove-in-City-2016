using UnityEngine;
using System.Collections;

public class Btn : MonoBehaviour {

    UISprite _sprite;
	void Start () {
        _sprite = GetComponent<UISprite>();
	
	}
    void OnPress(bool isOver)
    {
        _sprite.cachedTransform.localScale = (isOver) ? Vector3.one * 0.95f : Vector3.one;
    }
}
