using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// 穴掘りアルゴリズム
public class MapGeneration : MonoBehaviour  {
  [SerializeField]int r_width = 5;
  [SerializeField]int r_height = 5;
  int way = 0;
  int wall = 1;
  int start = 2;
  int goal = 3;
  Room layer;
  Vector2Int startPos;
  Vector2Int goalPos;

  void Start() {
    layer = new Room(r_width,r_height);
    layer.Fill(wall);
  }

  void Update() {

  }

  Vector2Int GetStartPosition() {
    int x = Mathf.RoundToInt(Random.Range(0, r_width));
    int y = Mathf.RoundToInt(Random.Range(0, r_height));
    while ( x % 2 != 0 || y % 2 != 0) {
      x = Mathf.RoundToInt(Random.Range(0, r_width));
      y = Mathf.RoundToInt(Random.Range(0, r_height));
    }
    return new Vector2Int(x,y);
  }
  Vector2Int Dig(Vector2Int startPos) {}

  Dictionary<int,Vector2Int> GetPosition(Vector2Int startPos) {}

  void BuildMap() {}

}
