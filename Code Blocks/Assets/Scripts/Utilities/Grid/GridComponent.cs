using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridComponent : MonoBehaviour {

	// Variables

	public List<Vector3> columnPoints = new List<Vector3> ();
	public int columns;
	public int rows;
	int cellSize = 2;

	// Debug

	public bool debug;

	private void Start () {
		CreateGrid ();
	}

	private void Update () {
		if (debug) {
			DrawCells ();
		}
	}

	void CreateGrid () {
		
		Vector3 lastPointPos = transform.position;

		for (int r = 0; r < rows; r++) {

			CreateColumnPoints (lastPointPos);

			lastPointPos = new Vector3 (transform.position.x, lastPointPos.y - cellSize, 0);
		}
	}

	void CreateColumnPoints (Vector3 lastPointPos) {

		for (int c = 0; c < columns; c++) {

			if (c == 0) {
				columnPoints.Add (lastPointPos);
			} else {
				columnPoints.Add (new Vector3 (lastPointPos.x + cellSize, lastPointPos.y, 0));
				lastPointPos = new Vector3 (lastPointPos.x + cellSize, lastPointPos.y, 0);
			}
		}
	}

	#region Debug ______________________________________________________________

	void DrawCells () {
		for (int c = 0; c < columnPoints.Count; c++) {
			DrawCell (columnPoints[c]);
		}
	}

	void DrawCell (Vector3 pos) {
		Debug.DrawLine (new Vector3 (pos.x - HalfCellSize (), pos.y + HalfCellSize (), 0), new Vector3 (pos.x + HalfCellSize (), pos.y + HalfCellSize (), 0), Color.yellow);
		Debug.DrawLine (new Vector3 (pos.x + HalfCellSize (), pos.y + HalfCellSize (), 0), new Vector3 (pos.x + HalfCellSize (), pos.y - HalfCellSize (), 0), Color.yellow);
		Debug.DrawLine (new Vector3 (pos.x + HalfCellSize (), pos.y - HalfCellSize (), 0), new Vector3 (pos.x - HalfCellSize (), pos.y - HalfCellSize (), 0), Color.yellow);
		Debug.DrawLine (new Vector3 (pos.x - HalfCellSize (), pos.y - HalfCellSize (), 0), new Vector3 (pos.x - HalfCellSize (), pos.y + HalfCellSize (), 0), Color.yellow);
	}

	int HalfCellSize () {
		return cellSize / 2;
	}

	#endregion
}
