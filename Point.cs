internal class Point
{
    private int coordinateX;
    private int coordinateY;

    public Point(int coordinateX, int coordinateY)
    {
        this.coordinateX = coordinateX;
        this.coordinateY = coordinateY;
    }
    
    public int CoordinateX
    {
        get { return coordinateX; }
        set { this.coordinateX = value; }
    }

    public int CoordinateY
    {
        get { return this.coordinateY; }
        set { this.coordinateY = value; }
    }
    
    public override string ToString()
    {
        return $"{{{coordinateX};{coordinateY}}}";
    }
}
