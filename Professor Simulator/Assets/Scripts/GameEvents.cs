using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    public KeyCode TeclaApertada;

    public void Awake()
    {
        current = this;
    }

    void OnGUI()
    {
        TeclaApertada = Event.current.keyCode;
    }

    //public event Action GetKeyDownCode;
    /*public void OnKeyDown()
    {
        if (GetKeyDownCode != null)
        {
            GetKeyDownCode();
        }
    }
    */
}
