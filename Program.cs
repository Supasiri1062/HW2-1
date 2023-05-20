class Program{
    static void Main(string[] args){
        bool continueProgram = true;
        while(continueProgram){
            Console.Write("input number: ");
            int numRows = int.Parse(Console.ReadLine());
            if(numRows < 0){
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            } else {
                for (int i = 0; i <= numRows; i++){
                    for (int j = 0; j <= i; j++){
                        Console.Write(CalculatePascalValue(i, j) + " ");
                    }
                    Console.WriteLine();
                }
                continueProgram = false;
            }
           
        }
    }
    static int CalculatePascalValue(int row, int column){
        if(column == 0 || column == row){
            return 1;
        } else {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}