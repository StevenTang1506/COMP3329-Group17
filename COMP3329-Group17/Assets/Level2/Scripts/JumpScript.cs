using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DistanceBetweenTwoObjects : MonoBehaviour
{
    public GameObject obj;
    public float triggerDistance;
    public float distance;


    private float resetXPosition = 80;
    private float resetDistance = 50;

    private void Update()
    {
        distance = Vector3.Distance(transform.position, obj.transform.position);

        if (distance < triggerDistance)
        {


            transform.Translate(Vector3.left * Time.deltaTime);

        }
    }

}
