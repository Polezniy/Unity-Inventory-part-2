using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    private delegate void OnEnter();
    private event OnEnter onEnter;
    public ItemObject itemObject;
    public ManagerItem managerItem;
    private void OnGUI()
    {
        onEnter?.Invoke();
    }
    private void OnTriggerEnter(Collider HitBox)
    {
        Debug.Log(HitBox.tag);
        if (HitBox.tag == "Player")
        {
            onEnter += Take;
        }
    }

    private void OnTriggerExit(Collider HitBox)
    {
        if (HitBox.tag == "Player")
        {
            onEnter -= Take;
        }
    }
    private void Take()
    {
        if (Event.current.Equals(Event.KeyboardEvent("F")))
        {
            StaticScript.RenderItemObjToInventory(this);
            Destroy(this.gameObject);
        }
    }
}
