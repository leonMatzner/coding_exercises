class Grid{
    public int numRows;
    public int numColumns;

    public List<GridNode> letterNodes;

    public Grid(int rowCount, int columnCount, string gridText){
        this.numRows = rowCount;
        this.numColumns = columnCount;
        
        this.letterNodes = new List<GridNode>();
        
        // Create all GridNodes, without connections
        for(int row = 0; row < numRows; row++){
            for(int column = 0; column < numColumns; column++){
                int id = row * numColumns + column;
                char c = gridText[id];

                this.letterNodes.Add(new GridNode(id, c));
            }
        }

        // Connect east and west neighbours
        for(int row = 0; row < numRows; row++){
            for(int column = 0; column < (numColumns - 1); column++){
                GridNode westNode = this.letterNodes[row * numColumns + column];
                GridNode eastNode = this.letterNodes[row * numColumns + column + 1];

                westNode.east = eastNode;
                eastNode.west = westNode;
            }
        }

        // Connect north and south neighbours
        for(int row = 0; row < (numRows - 1); row++){
            for(int column = 0; column < numColumns; column++){
                GridNode northNode = this.letterNodes[row * numColumns + column];
                GridNode southNode = this.letterNodes[(row + 1) * numColumns + column];

                northNode.south = southNode;
                southNode.north = northNode;
            }
        }
    }

    private GridNode createNode(char c){
        return null;
    }

    public List<List<GridNode>> findAllOccurences(string searchTerm){
        return null;
    }

    private List<GridNode> getMatchingNodes(char c, List<GridNode> potentialNodes){
        return null;
    }
}