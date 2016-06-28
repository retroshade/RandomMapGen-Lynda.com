using UnityEngine;
using System.Collections;

public enum Sides {
	Bottom,	//0
	Right,	//1
	Left,	//2
	Top		//3
}

public class Tile {
	public int id = 0;
	public Tile[] neighbors = new Tile[4];
}
