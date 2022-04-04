using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainDrag : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
