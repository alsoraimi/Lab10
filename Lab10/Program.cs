﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine("There are 10 Movies in this list");


            Movies[] MovieList = new Movies[10];
            MovieList[0]= new Movies ("Star Wars" ,"SciFi" );
            MovieList[1]= new Movies ("2001: A Space Odyssey", "SciFi");
            MovieList[2]= new Movies ("Saw", "Horror" );
            MovieList[3]= new Movies ("Scream", "Horror");
            MovieList[4]= new Movies ("Saving Private Ryan", "Drama");
            MovieList[5]= new Movies ("The GodFather", "Drama");
            MovieList[6]= new Movies ("Up", "Animated");
            MovieList[7]= new Movies ("Finding Nemo", "Animated");
            MovieList[8]= new Movies ("Happy Gilmore", "Comedy");
            MovieList[9]= new Movies ("Super Troopers", "Comedy");

            Console.WriteLine(MovieList);

                 


        }
    }
}
