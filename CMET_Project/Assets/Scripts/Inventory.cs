using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public List<Item> bag;
    public Image invenIcon;
    int size;

	// Use this for initialization
	void Start () {
        bag = new List<Item>();
        size = bag.Count;
        invenIcon.enabled = false;
    }

    public void AddItem(Item i)
    {
        bag.Add(i);
        invenIcon.enabled = true;
    }

    public void RemoveItem(Item i)
    {
        bag.Remove(i);
    }

    void UpdateUI()
    {

    }
	
	// Update is called once per frame
	void Update () {


		
	}
}
