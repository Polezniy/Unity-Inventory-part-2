using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public static class StaticScript
{
    private static GameObject GetClearCell(GameObject cells)
    {
        for (int i = 0; i < cells.transform.childCount; i++) 
        {
            if (cells.transform.GetChild(i).childCount == 0)
            {
                return cells.transform.GetChild(i).gameObject;
            }
        }
        return null;
    }

    public static void AddStat(ItemObject itemObject)
    {
        Game.StatusPlayer.Damage += itemObject.Damage;
        Game.StatusPlayer.HP += itemObject.HP;
    }
    public static void RemoveStat(ItemObject itemObject)
    {
        Game.StatusPlayer.Damage -= itemObject.Damage;
        Game.StatusPlayer.HP -= itemObject.HP;
    }
    public static void RenderItemObjToInventory(TakeItem itemObject)
    {
        var cell = GetClearCell(StaticGameObject.cell);
        if (cell == null)
        {
            Debug.Log("Свободных мест нет!!!!!!!");
            return;
        }
        //TODO: Возможно стоит добавить шаблон.
        //TODO: Instantiate ???
        var itemGO = new GameObject();
        itemGO.transform.SetParent(cell.transform);
        itemGO.transform.localPosition = Vector3.zero;
        itemGO.transform.localScale = Vector3.one;
        itemGO.AddComponent<Image>().sprite = itemObject.itemObject.Sprite;
        var item = itemGO.AddComponent<Item>();
        item.itemObject = itemObject.itemObject;
        item.startCell = cell;
        item.managerItem = itemObject.managerItem;
    }
}
