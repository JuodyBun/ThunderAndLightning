using System;

namespace ThunderAndLightning
{
    public class Program
    {
        public string name; //remove once organized
        public string response;
        public void Main()
        {
            Console.WriteLine("Hello, I am going to tell you a story.");

            Introduction obj = new Introduction();
            // GetName method will repeat if user enters incorrect name
            obj.name = Console.ReadLine;

            
            Console.WriteLine($"Ok {name}, pleased to meet you. Let's begin our story. \n");

            Console.WriteLine("\n There is a Cambodian legend that, once, a long time ago, there lived a hermit. " +
                "People rarely saw him, for he lived in solitude at the top of a mountain. Still, people always talk, " +
                "and so word spread that the hermit possessed magical powers.");
            Console.WriteLine($"\n Do you know what a hermit is {name}? Type 'NO' for a definition; Press 'ENTER' to continue the story");
            response = Console.ReadLine().ToUpper();
            if (response == "NO") //create ERROR HANDLING, "Answer not understood" repeat "hermit definition method"
            {
                Console.WriteLine("\n Hermit: 'a person who lives in seclusion from society, usually for religious reasons.'");
                Console.ReadLine();
            }

            Console.WriteLine("\n Many wanted to learn the hermit's secrets, and among those longing to learn was the " +
                "lovely goddess of water, Moni Mekhala. Nimble and brave, she could swim through water and air, but she " +
                "wished to know more still. And, so she swam through the air to the hermit's home and asked him to be her teacher.");
            Console.WriteLine("\n Do you think the hermit took Moni Mekhala as a student? Type 'YES' or 'NO'");
            response = Console.ReadLine().ToUpper(); //create ERROR HANDLING, "Answer not understood" repeat 
            if (response == "YES")
            {
                Console.WriteLine($"\n Correct {name}! The hermit agrees to take Moni Mekhala as a student. \n");
            }
            if (response == "NO")
            {
                Console.WriteLine($"\n Not correct {name}! The hermit agrees to take Moni Mekhala as a student. \n");
            }

            Console.WriteLine("Soon the ogre known as Ream Eyso, a terrible giant who frightened all who saw him, " +
                "decided that he too wished to possess magical powers. And so Ream Eyso climbed the mountain and " +
                "knocked on the hermit's door with his enormous clawlike hands. When the hermit answered, he asked to become a student.");
            Console.WriteLine("\n Do you think the hermit took Ream Eyso as a student? Type 'YES' or 'NO'");
            response = Console.ReadLine().ToUpper(); //create ERROR HANDLING, "Answer not understood" repeat 
            if (response == "YES")
            {
                Console.WriteLine($"\n Correct {name}! The hermit agrees to take Ream Eyso as a student. \n");
            }
            if (response == "NO")
            {
                Console.WriteLine($"\n Not correct {name}! The hermit agrees to take Ream Eyso as a student. \n");
            }

            Console.WriteLine("The hermit did not care if one was a goddess and another was an ogre. He wanted to spread " +
                "knowledge to all who wanted to learn. \n");
            Console.ReadLine();

            Console.WriteLine("The lessons began. \n\n Ream Eyso and Moni Mekhala were attentive students. As time passed, " +
                "they learned a great deal of magic from their teacher. \n");
            Console.ReadLine();

            Console.WriteLine("As their lessons came to an end, the hermit decided he would offer his students a test. He " +
                "called them to his side and offered each an empty glass. \n");
            Console.WriteLine("'Take this glass,' he said, 'and return to me tomorrow. Your glass must be filled to the " +
                "very top with dew. The first who returns with a full glass will win a mystery prize.' \n");
            Console.ReadLine();

            Console.WriteLine("And so Moni Mekhala and Ream Eyso departed, glasses in hand. The first of them to present the " +
                "hermit with a glassful of this liquid would be the winner. And the winner would receive the mystery prize.");
            Console.ReadLine();

            Console.WriteLine($"{name}, do you know how morning dew is formed? Type 'NO' for a definition; Press 'ENTER' to " +
                $"continue the story");
            response = Console.ReadLine().ToUpper(); //create ERROR HANDLING, "Answer not understood" repeat 
            if (response == "NO")
            {
                Console.WriteLine("\n Dew: 'water in the form of droplets that appears on thin, exposed objects in the morning " +
                    "or evening due to condensation'");
                Console.ReadLine();
            }

            Console.WriteLine("Ream Eyso, the giant, had a clever idea which he thought would surely bring him the honor of " +
                "the best student. Early the next morning, Ream Eyso gathered as many leaves as he could, and one-by-one, let " +
                "the droplets of dew slide from each leaf into his glass.");
            Console.ReadLine();

            Console.WriteLine("Moni Mekhala approached her task differently. She spread a handkerchief on the grass and left it " +
                "there overnight. By morning the handkerchief was damp, and it took just a moment to squeeze the dew out of the " +
                "cloth and into the glass.");
            Console.ReadLine();

            Console.WriteLine("She arrived to present her full cup of dew to her teacher before the giant did. As a reward for her " +
                "ingenuity, the hermit bestowed upon Moni Mekhala a glittering ball. Ream Eyso received a magic ax as a consolation prize.");
            Console.ReadLine();

            Console.WriteLine("But instead of being the end of an isolated contest, this was just the beginning of an eternal struggle " +
                "for the small ball that Mekhala now carried was very powerful, much more so than the ax that Ream Eyso wielded. The " +
                "giant was jealous. He had to have that ball!");
            Console.ReadLine();

            Console.WriteLine($"Press a number {name} to explore the different ways on how Ream Eyso annoyed Moni Mekhala. 1) Flirting;" +
                $" 2) Stealing; 3) Stalking");
            response = Console.ReadLine().ToUpper();
            if (response == "1")
            {
                Console.WriteLine($"\n Flirting tactics \n");
            }
            if (response == "2")
            {
                Console.WriteLine($"\n Stealing tactics \n");
            }
            if (response == "3")
            {
                Console.WriteLine($"\n Stalking tactics \n");
            }

            Console.WriteLine("But the goddess was not at all bothered. Indeed, she was aware of all of his tricks and teased him in " +
                "return. Mekhala, without fear, refused and flew off into the clouds hoping to draw the demon away.");
            Console.ReadLine();
            Console.WriteLine("Ream Eyso took the bait, ripping through nimbus after nimbus in his crazed pursuit. Once far enough " +
                "away, Mekhala confronted her pursuer. Ream Eyso made one last demand but the goddess remained unfazed.");
            Console.ReadLine();
            Console.WriteLine("Enraged, he began to swing his diamond axe. Before he could hurl the weapon, Mekhala threw her crystal " +
                "into the air. As it climbed the height of the sky, it emitted powerful flashes of lightning that blinded the demon. " +
                "Ream Eyso let his axe loose in wild desperation.");
            Console.ReadLine();
            Console.WriteLine("As the weapon flew through the air it cut through clouds, creating deep, rolling peals of thunder. And " +
                "when the lightning and thunder mixed, precious seeds of water fell from heaven: rain. Mekhala drew close to Ream Eyso, " +
                "now blind and impotent without his axe.");
            Console.ReadLine();
            
            Console.WriteLine("Mekhala pondered on what she should do the giant. Press 1) if you think she should hurt him; Press 2) if " +
                "you think she should be compassionate");
            response = Console.ReadLine(); //create ERROR HANDLING, "Answer not understood" repeat 
            if (response == "2")
            {
                Console.WriteLine($"\n Correct {name}! \n");
            }
            if (response == "1")
            {
                Console.WriteLine($"\n Not correct {name}! \n");
                Console.ReadLine();
            }
                
            Console.WriteLine("Remembering the kindness and love of her teacher, Moni Mekhala chose compassion and flew into the sky. " +
                "Shortly later, Ream Eyso regained his strength, found his axe, and followed her. Thunder, lightning, and rain continued " +
                "to dance across the earth.");
            Console.ReadLine();
            Console.WriteLine("In this tale we find the origin of thunder and lightning. Ream Eyso's ax flying toward the goddess creates " +
                "the thunder. And Mekhala's sparkling ball lights up the heavens. Together they bring rain, the symbol of renewed life as " +
                "it imparts fertility to Cambodia's farmlands.");
            Console.ReadLine();

            Console.WriteLine($"{name}, Press '1' if you would like to learn more about the folktale?");
            Console.WriteLine("Press 'Enter' to exit the program.");
        }
        
        
    }
}
