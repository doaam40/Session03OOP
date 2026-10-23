namespace Session03_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1
            // a) method overload: more than one method in the same class have the same name but defer in number of parameters, datatypes,
            // and the rearange of datatype
            // method override: when a child want to change behavior of the parent's method, so the override method in child class, can
            // use keyword new or override

            // b) static binding: by using keyword new, happened in compilation time, and calling based on parent
            // dynamic binding: by using keyword override, happened in runtime, and calling based on child
            #endregion

            #region Q2
            // a) it prevents the inheritance of this class
            // b) sealed class prevents the inheritance of this class, but sealed method prevents the override of this method in the
            // child class
            // c) no, because the keyword sealed when applied to method so it prevents the method from overriding in any child
            #endregion
            #endregion

            #region Part 02 — Practical
            #region Q1

            #endregion

            #region Q2

            #endregion

            #region Q3

            #endregion

            #region Q4

            #endregion

            #region Q5

            #endregion

            #region Q6

            #endregion

            #region Q7

            #endregion

            #region Q8

            #endregion

            #region Q9
            Console.WriteLine("Delivery Center");
            Console.Write("Driver: ");
            string driver = Console.ReadLine();

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            StandardShipment standard = new StandardShipment("sh001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Tahrir", 3));
            ExpressShipment express = new ExpressShipment("sh002", "Mobile Phone", 2, 60, new DeliveryAddress("Alex", "Manzla", 6), 30);
            InternationalShipment international = new InternationalShipment("sh003", "Television", 8, 120, new DeliveryAddress("Giza", "Haram", 9), 100, "Germany");

            Shipment[] ship = { standard, express, international };

            for (int i = 0; i < 3; i++)
            {
                bool shipmentAdded = deliveryCenter.AddShipment(ship[i], i);
                string printStatus = shipmentAdded ? "The shipment was added successfully" : "The delivery center is full";
                Console.WriteLine(printStatus);
            }
            deliveryCenter.PrintAllShipments();

            Console.WriteLine("Printing Using DeliveryHelper");
            for (int i = 0; i < 3; i++)
            {
                DeliveryHelper.PrintShipmentDetails(deliveryCenter[i]);
            }

            Console.WriteLine("Updating Weight");
            Console.WriteLine($"Original Weight: {standard.Weight} KG");
            Console.Write($"Updated Weight: {standard.UpdateWeight(5)} KG");
            Console.Write($"Updated Weight After Packing: {standard.UpdateWeight(5, 0.5)} KG");

            Console.WriteLine("Printing Using Shipment[]");
            Shipment[] holding = { standard, express, international };
            foreach (Shipment s in holding)
            {
                s.PrintShipment();
            }

            //CompletedShipment class can not be inherit beause it is a sealed class
            //GenerateCustomsReport method can not be override in any child because it is a sealed method

            #endregion

            #endregion
        }
    }
}
