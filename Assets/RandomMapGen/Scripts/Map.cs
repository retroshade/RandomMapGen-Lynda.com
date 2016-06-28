using UnityEngine;
using System.Collections;

public class Map {
	public Tile[] tiles;
	public int cols;
	public int rows;

	public void NewMap(int width, int height) {
		cols = width;
		rows = height;

		tiles = new Tile[cols * rows];

		CreateTiles ();
	}

	private void CreateTiles() {
		var total = tiles.Length;

		for (var i = 0;i < total; i++) {
			var tile = new Tile ();
			tile.id = i;
			tiles [i] = tile;
		}
	}
}
