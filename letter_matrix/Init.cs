int numRows = 4;
int numColumns = 6;
string gridText = "KLPQRKATLDAIMZEATETAKATZ";

string searchTerm = "KATZE";

Grid grid = new Grid(numRows, numColumns, gridText);

List<List<GridNode>> matches = grid.findAllOccurences(searchTerm);

List<GridNode> allMatches = new List<GridNode>();
foreach(List<GridNode> match in matches){
    allMatches.AddRange(match);
}

grid.printSubGrid(allMatches);