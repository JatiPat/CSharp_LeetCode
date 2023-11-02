public class Solution {
    public int MaximalSquare(char[][] matrix) {

        // dynamic programming, bottom up approach
        int matrixHeight = matrix.GetLength(0); //find the width and height of the given matrix
        int matrixWidth = matrix[0].GetLength(0); 

        int maxWidth = 0; //used to find the max width of the small matrix

        //create a temporary matrix one size bigger to host the outer edge the matrix
        int[,] tempMatrix = new int[matrixHeight+1,matrixWidth+1]; 

        for(int row = 1; row < matrixHeight + 1; row++ ){ //traveling through each row
             for(int col = 1; col < matrixWidth + 1; col++ ){ //traveling through each column
                 if (matrix[row -1][col-1] == '1'){ //if a '1' is found
                    int top = tempMatrix[row-1,col]; //store the value above it
                    int left = tempMatrix[row,col-1]; //store the value left of it
                    int topLeft = tempMatrix[row-1,col-1]; //store the value across from it in topLeft
                    int min = Math.Min(top,Math.Min(left, topLeft)); //find the min value
                    tempMatrix[row,col] = min+1; // add 1 to the min value and add it into tempMatrix

                    maxWidth = Math.Max(maxWidth, tempMatrix[row,col]); //the max value will be 


                }
            }
        }
        
        return maxWidth * maxWidth; //return the area and it's a square therefore it's maxWidth * maxWidth; 
    }
}
