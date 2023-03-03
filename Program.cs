namespace homework1{
    class program{
        static void Main(string[] args){
            Console.Write("password : ");
            int p = int.Parse(Console.ReadLine());
            
            Console.Write("agency :");
            string o =(Console.ReadLine());

            if(p <= 999999 && p >= 0){
                int a = p / 100000 % 10;
                int b = p / 10000 % 10;
                int c = p / 1000 % 10;
                int d = p / 100 % 10;
                int e = p / 10 % 10;
                int f = p % 10;

            if(o == "CIA") {
                if(f%3==0 && e !=1 && e !=3 && e !=5 && (c == 6 ||c ==7 || c == 9)){
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
        }
            else if (o =="FBI") {
                if(b %3 == 0 && (d !=6 && d % 2 ==0) && (a == 4 || a == 5|| a == 6|| a == 7)){
                Console.WriteLine("True");
            } 
            else {
                Console.WriteLine("False");
            }
        }
            else if (o =="NSA") {
                if((d == 3 || d == 9) && (f == 1 || f == 2|| f == 3|| f == 5 || f ==6) && (a ==7 || b==7 || c==7 || e==7||f==7 )){
                Console.WriteLine("True");

            } 
            else {
                Console.WriteLine("False");
            
            }
        } 

        }
    }
}
}
