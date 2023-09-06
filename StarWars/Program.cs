using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for node object of BST
    class Node
    {
        //mmebers of BST
        public Battleship data;
        public Node left, right;

        //overloaded constructor of node
        public Node(Battleship data)
        {
            this.data = data;
            left = null;
            right = null;

        }
    }
    //BST class
    class BinaryTreeImp
    {
        //members of BST class
        public Node root;
        public static int count = 0;
        //constructor of BST
        public BinaryTreeImp()
        {
            root = null;

        }
        //function to add a new node to BST
        public Node addNode(Battleship data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;

            }
            count++;
            return newNode;


        }
        //function to insert a node in BST on some index
        public void insertNode(Node root, Node newNode)
        {
            Node temp;
            temp = root;

            if (newNode.data.Cost < temp.data.Cost)
            {
                if (temp.left == null)
                {
                    temp.left = newNode;

                }

                else
                {
                    temp = temp.left;
                    insertNode(temp, newNode);

                }
            }
            else if (newNode.data.Cost > temp.data.Cost)
            {
                if (temp.right == null)
                {
                    temp.right = newNode;

                }

                else
                {
                    temp = temp.right;
                    insertNode(temp, newNode);
                }
            }
        }

        //function to dipslay whole BST
        public void displayTree(Node root)
        {
            Node temp;
            temp = root;

            if (temp == null)
                return;
            displayTree(temp.left);
            System.Console.WriteLine("Cost: "+temp.data.Cost+", Power: "+temp.data.CombatPower + " ");
            displayTree(temp.right);


        }

    }
    //main class
    class Program
    {
        //main funciton
        static void Main(string[] args)
        {
            //setting up initial budget for the fleet
            int budget = 0;
            Console.Write("Enter fleet budget: ");
            budget = Convert.ToInt32(Console.ReadLine());
            BinaryTreeImp btObj = new BinaryTreeImp();
            Node iniRoot = btObj.addNode(new Battleship(5, 10));
            LinkedList<Battleship> my_list = new LinkedList<Battleship>();
            //add some random ships in start
            btObj.insertNode(btObj.root, iniRoot);
            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random();
                int cst = rand.Next(0, 100);
                int poww = rand.Next(0, 100);
                btObj.insertNode(btObj.root, btObj.addNode(new Battleship(cst, poww)));
                my_list.AddLast(new Battleship(cst, poww));
            }
            btObj.displayTree(btObj.root);

            System.Console.WriteLine("The sum of nodes are " + BinaryTreeImp.count);
           //showing up a user menu
           //taking input choice to add or remove ship
           //based on choice, adding  new ship or removing exiting ship
            int cost, power;
            int choice = 0;
            do
            {
                Console.WriteLine("1. Add Ship ");
                Console.WriteLine("2. Remove Ship ");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Cost: ");
                        cost= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Combat Power: ");
                        power = Convert.ToInt32(Console.ReadLine());
                        if (cost <= budget)
                        {
                            my_list.AddLast(new Battleship(cost, power));
                            budget -= cost;
                            Console.WriteLine("Remaining budget is: " + budget);
                        }
                        else
                        {
                            Console.WriteLine("Sorry you are out of budget... ");
                        }
                        break;
                    case 2:
                        Console.Write("Enter Cost: ");
                        cost = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Combat Power: ");
                        power = Convert.ToInt32(Console.ReadLine());
                        my_list.Remove(new Battleship(cost, power));
                        budget += cost;
                        Console.WriteLine("Remaining budget is: " + budget);
                        break;
                    case 3:
                        Console.WriteLine("------------------- Good Bye -------------");
                        break;
                    default:
                        Console.WriteLine("Wrong Input...");
                        break;
                }
                //showing list of all ships on the end
                foreach (Battleship batt in my_list)
                {
                    Console.WriteLine("Cost: "+batt.Cost+", Power: "+batt.CombatPower);
                }
            } while (choice != 3);
        }
    }
}
