class GridNode{
    public int id;
    public GridNode? north;
    public GridNode? east;
    public GridNode? south;
    public GridNode? west;
    
    public GridNode(int id){
        this.north = null;
        this.east = null;
        this.south = null;
        this.west = null;
        
        this.id = id;
    }
}