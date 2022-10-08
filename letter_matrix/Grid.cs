class Grid{
    public int numRows;
    public int numColumns;
    public String gridText;

    public List<GridNode> letterNodes;

    public Grid(int numRows, int numColumns, String searchTerm, String gridText){}

    private GridNode createNode(char c){}

    public List<int> findAllOccurences(String searchTerm){}

    private List<GridNode> getMatchingNodes(char c, List<GridNodes> potentialNodes){}
}