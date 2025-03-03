﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class AmmoBuyItemController: MonoBehaviour
{
	public Image Image;
	public Text HPText;
	public Text AmmoText;
	public Text Name;
	public Text Price;
	public Button Buy;

	public Gun gun { get; set; }

	public AmmoBuyController ammoBuyController  { get; set; }

	void Start() {
		Buy.onClick.AddListener (() => OnBuySelect ());
	}

	public void Render() {
		int ammoPrice = 5 * gun.ammoPrice;
		Name.text = gun.name;
		HPText.text = "Damage : " + gun.hitPoint;
		AmmoText.text = "Ammo : " + gun.ammo;
		Price.text = "Buy for " + ammoPrice;

		if ((GameController.Instance.profile.coins < ammoPrice) || (gun.ammo >= gun.maxAmmo)) {
			Buy.interactable = false;
		}
	}

	public void OnBuySelect() {
		ammoBuyController.Buy (gun);
		Render ();
	}
}
