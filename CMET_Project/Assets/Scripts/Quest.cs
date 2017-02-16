using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest {

    public string t;
    public string desc;
    public string tit;
    public bool completed;
    public int ID;

    public Quest(string title, string description, string type)
    {
        tit = title ;
        desc = description;
        completed = false;
        if(type.Equals("collect") || type.Equals("goto") || type.Equals("talk"))
        {
            t = type;
        }
    }

    public void setID(int num)
    {
        ID = num;     
    }



	// Use this for initialization
	
	
}
