using System.Collections;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1f;

    private Coroutine LookCoroutine;

    public int TicksPerSecond = 60;
    public bool Pause = false;

    private void Start()
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
            if (!Pause)
            {
                StartRotating();
            }

            yield return Wait;
        }
    }

}
