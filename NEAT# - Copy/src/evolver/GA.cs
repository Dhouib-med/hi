using System;

	namespace evolver
	{

		using Client = neat.Client;
		using Neat = neat.Neat;

		public class GA
		{

			public static void rateClient(Client client)
			{


			}

			public static void evolve(Neat neat)
			{
				for (int i = 0; i < neat.Max_clients; i++)
				{
					rateClient( neat.getClient(i));
				}
				neat.evolve();
			}

			public static void Main(string[] args)
			{

			

				Neat neat = new Neat(?,?,1000);
				neat.CP = 3;

				neat.PROBABILITY_MUTATE_WEIGHT_RANDOM = 0.01;
				neat.PROBABILITY_MUTATE_WEIGHT_SHIFT = 0.01;
				neat.PROBABILITY_MUTATE_LINK = 0.3;
				neat.PROBABILITY_MUTATE_NODE = 0.1;
				neat.SURVIVORS = 0.3;

				for (int i = 0; i < neat.Max_clients; i++)
				{
					rateClient( neat.getClient(i));
				}


				for (int i = 0; i < 200; i++)
				{
					Console.WriteLine("#################### " + i + " ######################");
					evolve( neat);
					neat.printSpecies();
					Console.WriteLine(neat.BestClient.Score);
					neat.printScoreInformation();
				}

				for (int i = 0; i < neat.Max_clients; i++)
				{
					rateClient( neat.getClient(i));
				}



			}

		}



	}