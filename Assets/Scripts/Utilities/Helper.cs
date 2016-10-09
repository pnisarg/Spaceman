﻿using System;
using System.Collections.Generic;
using UnityEngine;
public static class Helper
{
	public static void  addGameObjectCollectible(GameObject gamebject, Collectible collectible) {
		gamebject.AddComponent<GameObjectCollectible>();
		GameObjectCollectible gc = (GameObjectCollectible) gamebject.GetComponent<GameObjectCollectible> ();
		gc.collectible = collectible;
	}

	public static void  addGameObjectObstacle(GameObject gamebject, Obstacle obstacle) {
		gamebject.AddComponent<GameObjectObstacle>();
		GameObjectObstacle gc = (GameObjectObstacle) gamebject.GetComponent<GameObjectObstacle> ();
		gc.obstacle = obstacle;
	}

	public static Collectible getCollectibleFromGameObject(GameObject gameObject) {
		GameObjectCollectible component =  (GameObjectCollectible) gameObject.GetComponent<GameObjectCollectible> ();
		return component.collectible;
	}

	public static Obstacle getObstacleFromGameObject(GameObject gameObject) {
		GameObjectObstacle component =  (GameObjectObstacle) gameObject.GetComponent<GameObjectObstacle> ();
		return component.obstacle;
	}
}

