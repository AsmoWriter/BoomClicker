using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReyDestroyer : MonoBehaviour
{
    private bool _keyPressed;
    private string _destroyTag = "BombTag";

    private void Update()
    {
        _keyPressed = Input.GetMouseButtonDown(0);

        if (!_keyPressed)
            return;

        Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D _hit = Physics2D.Raycast(ray, Vector2.zero);
        if (_hit.transform != null)
        {
           
            if (_hit.transform.tag == _destroyTag)
            {
                Destroy(_hit.transform.gameObject);
            }
        }
    }
}
