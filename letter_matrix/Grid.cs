class Grid{
    public int numRows;
    public int numColumns;
    public String gridText;

    public List<GridNode> letterNodes;

    public Grid(int numRows, int numColumns, String gridText){}

    private GridNode createNode(char c){}

    public List<List<GridNode>> findAllOccurences(String searchTerm){}

    private List<GridNode> getMatchingNodes(char c, List<GridNode> potentialNodes){}
}