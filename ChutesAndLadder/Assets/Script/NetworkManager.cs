using UnityEngine;
using System.Collections;

/*ONLINE MULTIPLAYER INSPIRED ME BY THIS ARTICLE*/
/*http://www.paladinstudios.com/2013/07/10/how-to-create-an-online-multiplayer-game-with-unity/*/

public class NetworkManager : MonoBehaviour {

	private const string typeName = "UniqueGameName";
	private const string gameName = "Room Name";

	private static NetworkManager instance;

	public static NetworkManager Instance{
		get{return instance;}
	}
	
	void Awake() {
		DontDestroyOnLoad(this);
		
		if (instance == null)
			instance = this;
		else if (instance != this) {
			Destroy(gameObject);
			return;
		}
	}

	private void StartServer()
	{
//		MasterServer.ipAddress = “127.0.0.1″;
		Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
		MasterServer.RegisterHost(typeName, gameName);
	}

	void OnServerInitialized()
	{
		Debug.Log("Server Initializied");
		Application.LoadLevel ("OnlineLobby");
	}

	void OnGUI()
	{

		if (!Network.isClient && !Network.isServer)
		{
			if (GUI.Button(new Rect(100, 100, 250, 100), "Start Server"))
				StartServer();
			
			if (GUI.Button(new Rect(100, 250, 250, 100), "Refresh Hosts"))
				RefreshHostList();
			
			if (hostList != null)
			{
				for (int i = 0; i < hostList.Length; i++)
				{
					if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName))
						JoinServer(hostList[i]);
				}
			}
		}
	}


	private HostData[] hostList;
	
	private void RefreshHostList()
	{
		MasterServer.RequestHostList(typeName);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}

	private void JoinServer(HostData hostData)
	{
		Network.Connect(hostData);
		Application.LoadLevel ("OnlineLobby");
	}
	
	void OnConnectedToServer()
	{
		Debug.Log("Server Joined");
	}
}


