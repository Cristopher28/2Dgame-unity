using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camara : MonoBehaviour
{
    public float xMargin = 1.0f;
    public float yMargin = 1.0f;

    public float xsmooth = 10.0f;
    public float ysmooth = 10.0f;

    public Vector2 maxXandY;
    public Vector2 minXandY;

    public Transform CamaraTarget;

     void Awake()
    {
        CamaraTarget = GameObject.FindGameObjectWithTag ("CamaraTarget").transform;
    }

    bool CheckXMargin()
    {
        return Mathf.Abs(transform.position.x - CamaraTarget.position.x) > xMargin;
    }

    bool CheckYMargin()
    {
        return Mathf.Abs(transform.position.y - CamaraTarget.position.y) > yMargin;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void FixedUpdate()
    {
        TrackPlayer();
    }

    void TrackPlayer()
    {
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        if (CheckXMargin())
        {
            targetX = Mathf.Lerp(transform.position.x, CamaraTarget.position.x, xsmooth * Time.deltaTime);
        }
        if (CheckYMargin())
        {
            targetY = Mathf.Lerp(transform.position.y, CamaraTarget.position.y, ysmooth * Time.deltaTime);
        }

        targetX = Mathf.Clamp(targetX, minXandY.x, maxXandY.x);
        targetY = Mathf.Clamp(targetY, minXandY.y, maxXandY.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}
