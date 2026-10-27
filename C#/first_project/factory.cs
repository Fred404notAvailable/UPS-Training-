    using System;


    public interface IPayment {
        void Pay();
    }

    public class UPI : IPayment {
        public void Pay() => Console.WriteLine("Paid using UPI");
    }

    public class Cash : IPayment {
        public void Pay() => Console.WriteLine("Paid using Cash");
    }


    public class PaymentFactory {
        public static IPayment GetShape(string shapeType) {
            if (shapeType == "UPI")
                return new UPI();
            else if (shapeType == "Cash")
                return new Cash();
            else
                return null;
        }
    }

    class Program {
        static void Main() {
            IPayment shape1 = PaymentFactory.GetShape("UPI");
            shape1.Pay();

            IPayment shape2 = PaymentFactory.GetShape("Cash");
            shape2.Pay();
        }
    }