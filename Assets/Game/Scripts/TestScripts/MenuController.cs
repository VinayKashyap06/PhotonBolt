using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.UI;
using Bolt.Matchmaking;
using System;
using UdpKit;

public class MenuController : GlobalEventListener
{
    [SerializeField]
    private Button buttonPrefab;
    [SerializeField]
    private Transform buttonParent;

    public void StartServer()
    {
        BoltLauncher.StartServer();
    }
    public void StartClient()
    {
        BoltLauncher.StartClient();
    }
    /// <summary>
    /// Wheneever either client or server network starts
    /// </summary>
    public override void BoltStartDone()
    {
        if (BoltNetwork.IsServer)
        {
            string roomName = "Test Match";
            BoltMatchmaking.CreateSession(roomName);
            //BoltNetwork.LoadScene("Game");
        }
    }
    /// <summary>
    /// Players added in sessions
    /// </summary>
    /// <param name="sessionList"></param>
    public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
    {
        foreach (var session in sessionList)
        {
            //store sessions as udp session
            UdpSession photonSession = session.Value as UdpSession;
            ////check the source only then connect
            //if (photonSession.Source==UdpSessionSource.Photon)
            //{
            //    //connect to network
            //    BoltNetwork.Connect(photonSession);
            //}
            //if (session.Value!=null)
            //{
            //instantiate button
                Debug.Log("adding button");
                Button joinButtonClone = GameObject.Instantiate(buttonPrefab.gameObject).GetComponent<Button>();
                joinButtonClone.gameObject.SetActive(true);
                joinButtonClone.transform.SetParent(buttonParent);
                joinButtonClone.transform.localScale = Vector3.one;
                joinButtonClone.onClick.AddListener(()=>JoinSession(photonSession));
            //}
        }

    }

    private void JoinSession(UdpSession udpSession)
    {
        if (udpSession.Source==UdpSessionSource.Photon)
        {
            BoltNetwork.Connect(udpSession);
        }
    }
}

