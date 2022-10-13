
int numRows = 4;
int numColumns = 6;
string gridText = "KCLQRKATLDAIMZEATETAKATZ";

string searchTerm = "KATZEN";

if(true){
    numRows = 6;
    numColumns = 6;
    gridText = "JPLCVXMHPAPIPAMPOEIRZIPREQREABREMVSP";
    searchTerm = "PAPIER";
}

// Create random grid
if(false){
    gridText = "";
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //alphabet = "KATZEN";

    numRows = 6;
    numColumns = 6;
    int randomStringLength = numRows * numColumns;

    Random rand = new Random();
    for(int i = 0; i < randomStringLength; i++){
        int alphabetIndex = rand.Next(alphabet.Length);

        gridText += alphabet[alphabetIndex];
    }
    Console.WriteLine(gridText);
}

Grid grid = new Grid(numRows, numColumns, gridText);

List<List<GridNode>> matches = grid.findAllOccurences(searchTerm);

List<GridNode> allMatches = new List<GridNode>();
foreach(List<GridNode> match in matches){
    allMatches.AddRange(match);
}

//grid.printSubGrid(allMatches);

Console.WriteLine(matches.Count);