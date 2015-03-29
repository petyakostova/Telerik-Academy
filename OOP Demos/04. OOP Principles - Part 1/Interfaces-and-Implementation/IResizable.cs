public interface IResizable // possible variants for resize
{
    //void Resize(int weight);  // this is not implemented and will give build error => resize by given value
    void Resize(int weightX, int weightY);  // by x and by y
    void ResizeByX(int weightX);
    void ResizeByY(int weightY);
}
