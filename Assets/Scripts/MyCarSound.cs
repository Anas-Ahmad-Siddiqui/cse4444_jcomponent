using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MyCarSound : MonoBehaviour
{
    AudioSource audioSource;
    public float minPitch = 1f;
    private float pitchFromCar;
    //public script;
    PhotonView view;

    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch;
        view = GetComponent<PhotonView>();
            
    }

    // Update is called once per frame
    void Update()
    {
        view = GetComponent<PhotonView>();
        if (view.IsMine)
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.pitch = minPitch;
            pitchFromCar = CarController.cc.carCurrentSpeed + 1;
            if (pitchFromCar < minPitch)
                audioSource.pitch = minPitch;
            else
                audioSource.pitch = pitchFromCar;
        }
        if (!view.IsMine)
        {
            audioSource.volume = 0f;
        }
        
    }
}