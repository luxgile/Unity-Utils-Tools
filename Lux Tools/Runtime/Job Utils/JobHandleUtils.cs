using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;

public class JobHandleUtils : MonoBehaviour
{
    private List<JobHandle> handles = new List<JobHandle>();

    private static JobHandleUtils instance;
    private static JobHandleUtils Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<JobHandleUtils>();
                if(instance == null)
                {
                    GameObject go = new GameObject("[Job Handle Utils]", typeof(JobHandleUtils));
                    instance = go.GetComponent<JobHandleUtils>();
                }
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public static void FinishJobAtComplete(JobHandle job)
    {
        Instance.handles.Add(job);
    }

    private void Update()
    {
        if (handles.Count == 0)
            return;

        for (int i = 0; i < handles.Count; i++)
        {
            JobHandle handle = handles[i];
            if (handle.IsCompleted)
                handle.Complete();
        }
    }
}
