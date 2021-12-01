using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    int trackNumber = 0;

    public void CreateRoom()
    {
        if (trackNumber != 0)
        {
            PhotonNetwork.CreateRoom(createInput.text);
        }
        else
        {
            Debug.Log("Select the map first !!!!");
        }
            
    }

    public void JoinRoom()
    {
        if (trackNumber != 0)
        {
            PhotonNetwork.JoinRoom(joinInput.text);
        }
        else
        {
            Debug.Log("Select the map first !!!!");
        }
        
    }

    public void setTrack1()
    {
        trackNumber = 1;
    }

    public void setTrack2()
    {
        trackNumber = 2;
    }

    public void GoToMenu()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("menu");
    }

    public override void OnJoinedRoom()
    {
        if(trackNumber == 1)
        {
            PhotonNetwork.LoadLevel("TRACK_1");
        }
        else if(trackNumber == 2)
        {
            PhotonNetwork.LoadLevel("TRACK_3");
        }
    }
}
