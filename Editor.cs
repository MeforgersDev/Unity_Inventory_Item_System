using UnityEditor;
using UnityEngine;

public class ItemEditor : EditorWindow
{
    private ItemDatabase itemDatabase;
    private Item newItem = new Item();

    [MenuItem("Window/Item Editor")]
    public static void ShowWindow()
    {
        GetWindow<ItemEditor>("Item Editor");
    }

    void OnGUI()
    {
        if (itemDatabase == null)
        {
            itemDatabase = CreateInstance<ItemDatabase>();
        }

        GUILayout.Label("New Item", EditorStyles.boldLabel);
        newItem.itemName = EditorGUILayout.TextField("Item Name", newItem.itemName);
        newItem.description = EditorGUILayout.TextField("Description", newItem.description);
        newItem.itemType = (ItemType)EditorGUILayout.EnumPopup("Item Type", newItem.itemType);
        newItem.value = EditorGUILayout.IntField("Value", newItem.value);
        newItem.icon = (Sprite)EditorGUILayout.ObjectField("Icon", newItem.icon, typeof(Sprite), false);

        if (GUILayout.Button("Add Item"))
        {
            itemDatabase.AddItem(newItem);
            newItem = new Item();
        }
    }
}
