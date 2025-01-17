using Assets.Scripts;
using UnityEngine;

public class AppointmentCell : MonoBehaviour
{
    public GameObject cell;
    void Awake()
    {
        StaticGameObject.cell = cell;
    }
}
