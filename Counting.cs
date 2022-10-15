using System;
using System.Linq;
using System.Collections.Generic;

namespace counting
{
    public static class Program
{
	public static void Main()
	{
		Dictionary<int,string> name=new Dictionary<int,string>();
          name.Add(1,"ooo");
          name.Add(2,"ooo");
          name.Add(3,"ooo");
          name.Add(4,"oo");
          name.Add(5,"oo");
          name.Add(6,"ocoo");
          
	Random co=new Random();
	
	Console.WriteLine("Count the c");
	
	
		
		int score=0;
		string again="y";
		try{
		while(again.Equals("y")){
			int count=0;
			for(int k=0;k<=10;k++){
				int x=co.Next(1,7);
		
				if(x==6)
				{count++;}
				Console.Write(name[x]);
			}
		
			Console.Write("\nHow many c ?: ");
			string com= Console.ReadLine();
			if (com!="/s"){
				int read=Convert.ToInt32(com);
		
				if(read==count)
					{	
						score+=100;
						Console.Clear();
						Console.WriteLine("Score:"+score+"\n write /s to stop the game");
						
					}
				else {Console.WriteLine("Sorry there are "+count+" c's\nScore: "+ score+"\nwrite /s to stop the game");}
			}else{
				Console.Clear();
				Console.WriteLine("Final Score: "+score);
				again="n";
			}
			

		}
		}catch(Exception ){
		Console.WriteLine("An error occurred :(");}
		
	
		

	}
}
}
