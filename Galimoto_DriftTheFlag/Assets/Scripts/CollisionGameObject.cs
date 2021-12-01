using UnityEngine;
using Photon.Pun;

public class CollisionGameObject : MonoBehaviour
{

    private PhotonView PV;
    int touched = 0;

    void Start()
    {
        PV = GetComponent<PhotonView>();
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Do something else here");
            touched = 1;
            if (PV.IsMine)
            {
                
                PV.RPC("changeScene", RpcTarget.All, 1);
            }
        }
    }

    [PunRPC]
    void changeScene(int value)
    {
        if(touched == 0)
        {
            PhotonNetwork.LoadLevel("youLoseScreen");
        }
        else if(touched == 1)
        {
            PhotonNetwork.LoadLevel("youWinScreen");
        }
        
    }

}