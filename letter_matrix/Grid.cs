class Grid{
    public int numRows;
    public int numColumns;

    public List<GridNode> letterNodes;

    public Grid(int rowCount, int columnCount, String gridText){
        this.numRows = rowCount;
        this.numColumns = columnCount;
        
        this.letterNodes = new List<GridNode>();
    }

    private GridNode createNode(char c){
        return null;
    }

    public List<List<GridNode>> findAllOccurences(String searchTerm){
        return null;
    }

    private List<GridNode> getMatchingNodes(char c, List<GridNode> potentialNodes){
        return null;
    }
}