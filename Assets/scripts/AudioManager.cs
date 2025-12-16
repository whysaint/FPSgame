using UnityEngine;

public class AudioManager : MonoBehaviour, IGameManager
{
    public ManagerStatus Status { get; private set; }

    private NetworkService _network;

    public float SoundValue
    {
        get { return AudioListener.volume;}
        set { AudioListener.volume = value; }
    }

    public bool SoundMute
    {
        get { return AudioListener.pause;}
        set { AudioListener.pause = value; }
    }

    public void StartUp(NetworkService service)
    {
        Debug.Log("Audio manager starting....");

        _network = service;

        SoundValue = 1f;

        Status = ManagerStatus.Started;
    }
    
    public void Startup(NetworkService service)
    {
        Debug.Log("Audio manager starting...");

        Status = ManagerStatus.Started;
    }
}
