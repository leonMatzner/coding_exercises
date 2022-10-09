class GridNode{
    public int id;
    public char letter;
    public GridNode? north;
    public GridNode? east;
    public GridNode? south;
    public GridNode? west;
    
    public GridNode(int id, char letter){
        this.north = null;
        this.east = null;
        this.south = null;
        this.west = null;
        
        this.id = id;
        this.letter = letter;
    }
    
    public List<GridNode> getNeighbours(){
        List<GridNode> neighbours = new List<GridNode>();

        if(north != null) {neighbours.Add(this.north);}
        if(east != null) {neighbours.Add(this.east);}
        if(south != null) {neighbours.Add(this.south);}
        if(west != null) {neighbours.Add(this.west);}
        
        return neighbours;
    }
}