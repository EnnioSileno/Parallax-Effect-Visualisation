using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpingLine : MonoBehaviour
{

    public Transform StartPoint;
    public Transform EndPoint;

    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, StartPoint.position);
        lr.SetPosition(1, EndPoint.position);
    }
}
