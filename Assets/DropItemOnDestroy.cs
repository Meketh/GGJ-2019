using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemOnDestroy : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _items;

    private void OnDestroy()
    {
        var itemIndex = Random.Range(0, _items.Length);

        var newItem = Instantiate(_items[itemIndex]);
    }
}
