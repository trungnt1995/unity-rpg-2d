﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public Image buttonImage;
    public Text amountText;
    public int buttonValue;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Press()
    {   
        if(GameMenu.instance.theMenu.activeInHierarchy){

            if(GameManager.instance.itemsHeld[buttonValue] !="")
            {
                GameMenu.instance.SelectedItem(GameManager.instance.GetItemDetail(GameManager.instance.itemsHeld[buttonValue]));
            }
        }

        if(Shop.instance.shopMenu.activeInHierarchy)
        {
            if(Shop.instance.buyMenu.activeInHierarchy)
            {
                Shop.instance.SelectBuyItem(GameManager.instance.GetItemDetail(Shop.instance.itemsForSale[buttonValue]));
            }

            if(Shop.instance.sellMenu.activeInHierarchy)
            {
                Shop.instance.SelectSellItem(GameManager.instance.GetItemDetail(GameManager.instance.itemsHeld[buttonValue]));
            }
        }

        if(GameManager.instance.battleActive)
        {
          BattleManager.instance.SelectedBattleItem(GameManager.instance.GetItemDetail(GameManager.instance.itemsHeld[buttonValue]));
        }
    }
}
