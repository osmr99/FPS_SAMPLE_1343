using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class ShakeEffect : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;
    bool shaking = false;
    float time = 0f;
    [SerializeField] float shakePower = 2f;
    [SerializeField] float shakeTime = 0.275f;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (shaking)
        {
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = shakePower;
        }
        if(shaking && time > shakeTime)
        {
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
            shaking = false;
        }
    }

    public void startShaking()
    {
        shaking = true;
        time = 0;
    }
}
