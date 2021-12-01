using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject GA = null;
    public CameraFollow camFollowSrcipt;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;
    public Quaternion rotation;
    //Quaternion rotation = new Quaternion(0f, -36f, 0f, 100f);
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        GA = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, rotation);
        //GA = GameObject.Find("car_1");
        camFollowSrcipt.target = GA.transform;
    }

    public void GoToMenu()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("menu");
    }
}
