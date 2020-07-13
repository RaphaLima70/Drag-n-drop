using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_drag : MonoBehaviour {

    Vector3 ponteiro;

    public void OnMouseDrag()
    {
        ponteiro = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ponteiro.y = transform.position.y;
        ponteiro.z = transform.position.z;
        transform.position = ponteiro;
    }

}
