using System.Drawing;
using System.Collections.Generic;
using Multiton.Enum;
using System;

namespace Multiton.Models
{
    public class Tema
    {
        public  String Nome       { get; private set; }
        public  Color  Background { get; private set; }
        public  Color  FontColor  { get; private set; }

        private static readonly IDictionary<Temas, Tema> temas = new Dictionary<Temas, Tema>
        {
            { Temas.FIRE, new Tema() { Nome = "FIRE",Background = Color.Yellow, FontColor = Color.Black } },
            { Temas.SkY,  new Tema() {  Nome = "SKY", Background = Color.Green, FontColor = Color.Blue  } }
        };
        
        public static Tema GetInstance(Temas tema)
        {
            return temas[tema];
        } 
    }
}
