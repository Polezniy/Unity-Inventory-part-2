using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.Progress;

public class ManagerItem : MonoBehaviour
{
    public GameObject pos;
    public GameObject cell;
    public GameObject player;
    public bool create;
    public ItemObject itemObject;

    // Update is called once per frame
    void Update()
    {
        if (create)
        {
            create = false;
            CreateItem(itemObject);
        }

    }
    public void CellToRemovePanel(Item item)
    {
        var createItem = Instantiate(item.itemObject.Prefab, player.transform.position, new Quaternion());
        createItem.GetComponent<TakeItem>().managerItem = item.managerItem;
    }
    public void ArmorPlayerToRemovePanel(Item item)
    {
        StaticScript.RemoveStat(item.itemObject);
        var createItem = Instantiate(item.itemObject.Prefab, player.transform.position, new Quaternion());
        createItem.GetComponent<TakeItem>().managerItem = item.managerItem;
    }
    public void CreateItem(ItemObject itemObject)
    {
        var createItem = Instantiate(itemObject.Prefab, pos.transform.position, new Quaternion());
        createItem.GetComponent<TakeItem>().managerItem = this;
    }
}
