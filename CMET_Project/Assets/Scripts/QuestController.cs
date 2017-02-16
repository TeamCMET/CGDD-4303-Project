using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestController : MonoBehaviour {

    List<Quest> quests;
    public Text tit;
    public Text desc;
    public Text completed;

    public Text tit1;
    public Text desc1;
    public Text completed1;

    // Use this for initialization
    void Start () {
        quests = new List<Quest>();
        quests.Add(new Quest("Go Here", "Go to blue sphere", "goto"));
        quests.Add(new Quest("PickUp", "Pick up green cyllinder", "collect"));
        quests[0].setID(0);

	}

    void DisplayQuests()
    {
        tit.text = quests[0].tit;
        desc.text = quests[0].desc;
        if (!quests[0].completed)
        {
            completed.text = "(incomplete)";
            completed.color = Color.red;
        }
        else
        {
            completed.text = "(complete)";
            completed.color = Color.green;
        }

        tit1.text = quests[1].tit;
        desc1.text = quests[1].desc;
        if (!quests[1].completed)
        {
            completed1.text = "(incomplete)";
            completed1.color = Color.red;
        }
        else
        {
            completed1.text = "(complete)";
            completed1.color = Color.green;
        }
    }

   public  Quest FindQuestByID(int ID)
    {
        return quests[ID];
    }
	
	// Update is called once per frame
	void Update () {
        DisplayQuests();	
	}
}
