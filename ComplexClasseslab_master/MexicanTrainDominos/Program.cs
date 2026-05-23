using System;
using MexicanTrainDominos;

namespace MexicanTrainDominosTests
{
	class Program
	{
		static void Main(string[] args) // Admittedly used some suggestions from the intellisense prompts that popped up when I wrote some of these. They were good suggestions.
		{
			TestDominoConstructors();
			TestDominoProperties();
			TestDominoToString();
			TestDominoEquals();

			TestBoneyardConstructor();
			TestBoneyardIndexer();
			TestBoneyardDraw();
			TestBoneyardIsEmpty();
			TestBoneyardShuffle();
			TestBoneyardToString();

			Console.WriteLine("Done testing!");
			Console.ReadLine();
		}

		static void TestDominoConstructors()
		{
			Domino d1 = new Domino();
			Domino d2 = new Domino(3, 5);

			Console.WriteLine("Testing Constructors for Domino class...");
			Console.WriteLine("Default constructor. Expecting [0|0]: " + d1.ToString());
			Console.WriteLine("Overloaded constructor. Expecting [3|5]: " + d2.ToString());
			Console.WriteLine();
		}

		static void TestDominoProperties()
		{
			Domino d = new Domino();

			d.Side1 = 4;
			d.Side2 = 6;

			Console.WriteLine("Testing Properties of Dominoes...");
			Console.WriteLine("Expecting Side1 of 4: " + d.Side1);
			Console.WriteLine("Expecting Side2 of 6: " + d.Side2);
			Console.WriteLine("Expecting [4|6]: " + d.ToString());
			Console.WriteLine();
		}

		static void TestDominoToString()
		{
			Domino d = new Domino(2, 4);

			Console.WriteLine("Testing Domino ToString Method...");
			Console.WriteLine("Expecting [2|4]: " + d.ToString());
			Console.WriteLine();
		}

		static void TestDominoEquals()
		{
			Domino d1 = new Domino(1, 6);
			Domino d2 = new Domino(1, 6);
			Domino d3 = new Domino(2, 5);

			Console.WriteLine("Testing Domino Equals() Method...");
			Console.WriteLine("Expecting True: " + d1.Equals(d2));
			Console.WriteLine("Expecting False: " + d1.Equals(d3));
			Console.WriteLine();
		}

		static void TestBoneyardConstructor()
		{
			Boneyard boneyard = new Boneyard(6);

			Console.WriteLine("Testing Constructor for Boneyard class...");
			Console.WriteLine("Expecting 28: " + boneyard.DominosRemaining);
			Console.WriteLine();
		}

		static void TestBoneyardIndexer()
		{
			Boneyard boneyard = new Boneyard(6);

			Console.WriteLine("Testing Boneyard Indexer Getter...");
			Console.WriteLine("Expecting first domino [0|0]: " + boneyard[0].ToString());

			boneyard[0] = new Domino(6, 6);

			Console.WriteLine("Testing Boneyard Indexer Setter..");
			Console.WriteLine("Expecting first domino [6|6]: " + boneyard[0].ToString());
			Console.WriteLine();
		}

		static void TestBoneyardDraw()
		{
			Boneyard boneyard = new Boneyard(6);

			Console.WriteLine("Testing Boneyard Draw() Method...");
			Console.WriteLine("Dominoes before draw. Expecting 28: " + boneyard.DominosRemaining);

			Domino drawnDomino = boneyard.Draw();

			Console.WriteLine("Drawn domino. Expecting [0|0]: " + drawnDomino.ToString());
			Console.WriteLine("Dominoes after draw. Expecting 27: " + boneyard.DominosRemaining);
			Console.WriteLine();
		}

		static void TestBoneyardIsEmpty()
		{
			Boneyard boneyard = new Boneyard(1);

			Console.WriteLine("Testing Boneyard IsEmpty() Method");
			Console.WriteLine("New double-one set has 3 dominoes.");
			Console.WriteLine("Expecting False: " + boneyard.IsEmpty());

			boneyard.Draw();
			boneyard.Draw();
			boneyard.Draw();

			Console.WriteLine("After drawing all dominoes.");
			Console.WriteLine("Expecting True: " + boneyard.IsEmpty());
			Console.WriteLine();
		}

		static void TestBoneyardShuffle()
		{
			Boneyard boneyard = new Boneyard(6);

			Console.WriteLine("Testing Boneyard Shuffle() Method...");
			Console.WriteLine("Before shuffle, first domino is usually [0|0]: " + boneyard[0].ToString());

			boneyard.Shuffle();

			Console.WriteLine("After shuffle, first domino may be different: " + boneyard[0].ToString());
			Console.WriteLine("Domino count should still be 28.");
			Console.WriteLine("Expecting 28: " + boneyard.DominosRemaining);
			Console.WriteLine();
		}

		static void TestBoneyardToString()
		{
			Boneyard boneyard = new Boneyard(2);

			Console.WriteLine("Testing Boneyard ToString() Method.");
			Console.WriteLine("A double-two set should display 6 dominoes:");
			Console.WriteLine(boneyard.ToString());
			Console.WriteLine();
		}
	}
}