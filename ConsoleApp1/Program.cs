using Tyuiu.MarakovAD.Sprint6.Task3.V9.Lib;
DataService ds = new DataService();
int[,] mtrx = new int[5, 5] { { -14, 25, 26, 18, 17 }, { 28, 10, 6, -2, 4 }, { 30, 25, -3, 11, -10 }, { 11, 32, -5, -20, 25 }, { 2, -18, 11, 8, -20 } };
Console.WriteLine(ds.Calculate(mtrx));
Console.WriteLine("dfg");
