using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cameraVR;
    public bool cameraVRActive = false;

    private float time = 0f;
    [SerializeField] private float timeLimit = 120f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public void SwitchCamera()
    {
        cameraVRActive = true;

        if (cameraVRActive)
        {
            Debug.Log(cameraVR.Priority);
            cameraVR.Priority = 20;

        }
        else
        {
            cameraVR.Priority = 0;
        }
    }

    public void Timer()
    {
        if (time < timeLimit)
        {
            time += Time.deltaTime;
        }
        else if (time >= timeLimit)
        {
            SwitchCamera();
            time = 0f;
        }
    }
}
