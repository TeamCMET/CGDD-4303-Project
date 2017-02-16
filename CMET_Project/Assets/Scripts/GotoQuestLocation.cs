using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoQuestLocation : MonoBehaviour {

   public int questID;
    public GameObject p;
    Renderer r;

	// Use this for initialization
	void Start () {
        r = GetComponent<Renderer>();
        questID = 0;
        r.material.color = Color.blue;
        r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { 
            p.GetComponent<QuestController>().FindQuestByID(questID).completed = true;
            Destroy(gameObject);
        }
    }
}
