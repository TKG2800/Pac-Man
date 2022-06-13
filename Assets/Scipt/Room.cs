public class Room {
  int Width;
  int Height;
  int outOfRange = -1;
  int[,] values;
  public Room( int width, int height ) {
    if (width > 0 && height > 0) {
      Width = width;
      Height = height;
      values = new int[Width,Height];
    }
  }
   public bool IsOutOfRange( int x, int y ) {
    if(x < 0 || x >= Width) {return true;}
    if(y < 0 || y >= Height) {return true;}
    return false;
  }
  public int Get( int x, int y ) {
    if(IsOutOfRange(x,y)) {
      return outOfRange;
    }
    return values[x,y];
  }
  public void Set( int x, int y,int v) {
    values[x,y] = v;
  }
  public void Fill(int val) {
    for (int i = 0 ; i < Width ; i++ ) {
      for (int j = 0; j < Height; j++ ) {
        Set(i,j,val);
      }
    }
  }
}
