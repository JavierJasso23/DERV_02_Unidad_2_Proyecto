using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothLookAt : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;

    private Coroutine LookCoroutine;

    public int TicksPerSecond = 60;
    public bool Pause = false;

    public void Start()
    {
        StartCoroutine(Rotate());
    }

    public void StartRotating()
    {
        if (LookCoroutine != null)
        {
            StopCoroutine(LookCoroutine);
        }

        LookCoroutine = StartCoroutine(LookAt());
    }

    private IEnumerator LookAt()
    {
        Quaternion lookRotation = Quaternion.LookRotation(Target.position - transform.position);

        float time = 0;

        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);

            time += Time.deltaTime * Speed;

            yield return null;
        }
    }

    private IEnumerator Rotate()
    {
        WaitForSeconds Wait = new WaitForSeconds(5f / TicksPerSecond);

        while (true)
        {
            if(!Pause)
            {
                StartRotating();
            }

            yield return Wait;
        }

    }

    // You can remove this, it is only for the demo.
   /* private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 30), "Look At"))
        {
            StartRotating();
        }
    }*/
}
