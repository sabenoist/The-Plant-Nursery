using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapData {
    public static GameObject map = null;
    public static GameObject mapTile = null;
    public static GameObject camera = null;
    public static GameObject player = null;
    public static GameObject proximateItem = null;
    public static List<GameObject> itemsOnMap = new List<GameObject>();
    public static Boolean itemCaptured = false;
    public static Boolean mapExists = false;
    public static Boolean gameControllerExists = false;
}
