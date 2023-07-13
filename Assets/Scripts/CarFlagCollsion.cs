using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class CarFlagCollsion : MonoBehaviour
{
    private PhotonView PV;
    int touched = 0;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Flag")
        {
            Debug.Log("Do something else here");
            if (PV.IsMine)
            {
                touched = 1;
                PV.RPC("changeScene", RpcTarget.All, 1);
            }
        }
    }

    [PunRPC]
    void changeScene(int value)
    {
        if (touched == 0)
        {
            PhotonNetwork.LoadLevel("youLoseScreen");
        }
        else if (touched == 1)
        {
            PhotonNetwork.LoadLevel("youWinScreen");
        }

    }
}
