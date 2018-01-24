using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerInfo : MonoBehaviour {

    [SerializeField]
    Text moneyText;
    private int money;
    private int numberItem;

    public List<Text> skillName;
    public List<int> skiilLevel;

    // Use this for initialization
    protected void Start ()
    {
        numberItem = 10;
        money = 100000;
        moneyText.text += "[ " + money + " ]";

        //for (int i = 0; i < 10; ++i)
        //{
        //    skiilLevel.Add(1);
        //    skillName[i].text = "skill level:[ " + skiilLevel[i] + " ]";
        //}
    }

    // Update is called once per frame
    protected void Update ()
    {
		
	}

    public void addMoney(int _money)
    {
        if (numberItem <= 10 && numberItem >= 0)
            money += _money;
        moneyText.text = "Gold:[ " + money + " ]";
    }

    public void addItem(int _numberItem)
    {
        if (numberItem <= 10 && numberItem >= 0)
            numberItem += _numberItem;
    }

    public void addSkillLevel(int index)
    {
        if (skiilLevel[index] < 10 && skiilLevel[index] >= 1)
        {
            skiilLevel[index] += 1;
        }

        skillName[index].text = "skill level:[ " + skiilLevel[index] + " ]";
    }
}
