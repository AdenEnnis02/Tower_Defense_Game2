class Position
{
    private double x;
    private double y;

    public Position()
    {
        this.x = 0.0;
        this.y = 0.0;
    }

    public Position(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Position(Position pos)
    {
        this.x = pos.x;
        this.y = pos.y;
    }

    public double getX()
    {
        return x;
    }

    public double getY()
    {
        return y;
    }

    public void setX(double x) 
    {
        this.x = x;
    }

    public void setY(double getY)
    {
        this.y = y;
    }

    // public (int,int) getPosition() 
    // {
    //     return (this.getX(),this.getY());
    // }

    public void setPosition(double x, double y) 
    {
        this.x = x;
        this.y = y;
    }
}