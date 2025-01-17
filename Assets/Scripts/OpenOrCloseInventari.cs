using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOrCloseInventari : MonoBehaviour
{
    public GameObject inventari;

    // Update is called once per frame
    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("I")))
        {
            inventari.SetActive(!inventari.activeSelf);
        }
    }
}
