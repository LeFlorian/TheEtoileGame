using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractObject_Fanart : InteractObject
{
    [SerializeField]
    private Image _fanart;


    public override void Action()
    {
        _fanart.gameObject.SetActive(!_fanart.IsActive());
    }

    private void Update()
    {
        if (Vector2.Distance(FindAnyObjectByType<PlayerController>().transform.position, transform.position) > 3f && _fanart.IsActive())
        {
             _fanart.gameObject.SetActive(false);
        }
    }


}
