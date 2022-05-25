using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// 穴掘りアルゴリズム
public class MapGeneration : MonoBehaviour  {
  [SerializeField]int r_width = 7;
  [SerializeField]int r_height = 7;
  int way = 0;
  int wall = 1;
  int start = 2;
  int goal = 3;
  Room layer;

  void Start() {
    layer = Room(r_width,r_height);
  }

  void Update() {

  }

  void Dig(Room layer,) {}
  void getSart() {}
  }
