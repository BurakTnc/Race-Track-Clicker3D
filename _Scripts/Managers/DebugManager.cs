using UnityEngine.UI;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    public static DebugManager instance;

    public Slider _camPosX, _camPosY, _camPosZ, _camRotX, _camRotY, _camRotZ, _carSpeed;
    private bool onDebugMode = false;


    private void Awake()
    {
        if (instance != this && instance != null) 
        {
            Destroy(this);
            return;
        }
        instance = this;
    }

    private void OnEnable()
    {
        CoreGameSignals.instance.OnDebugMode += DebugMode;
    }
    private void OnDisable()
    {
        CoreGameSignals.instance.OnDebugMode -= DebugMode;
    }

    private void DebugMode(bool debug)
    {
        onDebugMode = debug;
    }


}
