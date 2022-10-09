int numRows = 4;
int numColumns = 6;
String gridText = "KLPQRKATLDAIMZEATETAKATZ";

String searchTerm = "KATZE";

Grid grid = new Grid(numRows, numColumns, gridText);

List<List<GridNode>> matches = grid.findAllOccurences(searchTerm);