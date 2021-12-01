using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLobby()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("loading");
    }
    public void close()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("menu");
    }
}
