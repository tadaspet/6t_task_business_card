namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tri1 = new Triangle(6);
            var tri2 = new Triangle(3);

            var rect1 = new Quadrilateral(6);
            var rect2 = new Quadrilateral(3);

            var pent1 = new Pentagon(6);
            var pent2 = new Pentagon(3);

            var hex1 = new Hexagon(6);
            var hex2 = new Hexagon(3);

            List<Triangle> tri = new List<Triangle>() { tri1, tri2 };
            List<Quadrilateral> rec = new List<Quadrilateral>() { rect1, rect2 };
            List<Pentagon> pentagons = new List<Pentagon>() {  pent1, pent2 };
            List<Hexagon> hex = new List<Hexagon>() {  hex1, hex2 };

            List<double> triArea = tri.Select(tri => tri.GetArea()).ToList();
            triArea.ForEach(tri => Console.WriteLine(tri));
            Console.WriteLine();

            List<double> recArea = rec.Select(rec => rec.GetArea()).ToList();
            recArea.ForEach(rec => Console.WriteLine(rec));
            Console.WriteLine();

            List<double> pentArea = pentagons.Select(pent => pent.GetArea()).ToList();
            pentArea.ForEach(pent => Console.WriteLine(pent));
            Console.WriteLine();

            List<double> hexArea = hex.Select(hex => hex.GetArea()).ToList();
            hexArea.ForEach(hex => Console.WriteLine(hex));
        }
    }
}