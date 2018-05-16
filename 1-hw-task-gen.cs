   // zkoušení žáků
            Random rnd = new Random();

            int wrong = 0;
            int correct = 0;

            double count = 0;
            double ans = 0;
            int limit = 0;
           

            Console.WriteLine("Zadejte, kolik chcete příkladů:");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte horní hranici čísel");
            limit = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++){
                int n1 = rnd.Next(1, limit);
                int n2 = rnd.Next(1, limit);
                string task = n1 + "+" + n2 + "=?";
                int res = n1 + n2;
                Console.WriteLine(task);

                ans = int.Parse(Console.ReadLine());

                if (ans == res){
                    correct += 1;
                } else {
                    wrong += 1;
                }

            }


            Console.WriteLine("You have " + Math.Round(correct / count * 100) + "% correct");
            Console.ReadKey();
