using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public string name;
    public int itemID;
    public int questID;
    GameObject p;
    Renderer r;

	// Use this for initialization
	void Start () {
        p = GameObject.FindGameObjectWithTag("Player");
        r = gameObject.GetComponent<Renderer>();
        r.material.color = Color.green;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Inventory>().AddItem(this);
            p.GetComponent<QuestController>().FindQuestByID(questID).completed = true;
            //   GetComponent<Renderer>().enabled = false;
            gameObject.SetActive(false);
        }
    }
}
