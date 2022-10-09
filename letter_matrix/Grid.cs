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

    public List<List<GridNode>> findAllOccurences(string searchTerm){
        if(searchTerm == null || searchTerm.Length == 0){
            return null;
        }

        // The first list dimension separates layers of a tree of visited GridNodes
        // The tree is meant to be traversed starting from the leaf nodes (visitedGridNodeTree[n-1])
        List<List<(GridNode node, int parentOffset)>> visitedGridNodeTree = new List<List<(GridNode, int)>>();

        // initialize search criteria
        char currentChar = searchTerm[0];

        // initialize the first tree layer
        visitedGridNodeTree.Add(new List<(GridNode, int)>());
        foreach(GridNode node in this.letterNodes){
            if(node.letter == currentChar){
                visitedGridNodeTree[0].Add((node, 0));
                //Console.WriteLine(visitedGridNodeTree);
            }
        }
        
        // computes the further layers of tree of potential matches
        for(int charIndex = 1; charIndex < searchTerm.Length; charIndex++){
            currentChar = searchTerm[charIndex];

            visitedGridNodeTree.Add(new List<(GridNode, int)>());
            for(int parentIndex = 0; parentIndex < visitedGridNodeTree[charIndex - 1].Count; parentIndex++){
                foreach(GridNode node in getMatchingNeighbours(currentChar, visitedGridNodeTree[charIndex - 1][parentIndex].node)){
                    visitedGridNodeTree[charIndex].Add((node, parentIndex));
                }
            }
        }

        // TODO: traverse visitedGridNodeTree to get full paths and check for uniqueness of nodes
        return null;
    }

    private List<GridNode> getMatchingNeighbours(char c, GridNode originNode){
        List<GridNode> neighbours = originNode.getNeighbours();
        List<GridNode> matchingNeighbours = new List<GridNode>();
        
        // iterates through neighbours and adds matching nodes to be returned
        foreach(GridNode neighbour in neighbours){
            if(neighbour.letter == c){
                matchingNeighbours.Add(neighbour);
            }
        }
        
        return matchingNeighbours;
    }
}