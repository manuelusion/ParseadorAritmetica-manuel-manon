﻿using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorAritmetica
{
    internal class Aritmetica : aritmeticaBaseVisitor<int>
    {
        public override int VisitAritmetica([NotNull] aritmeticaParser.AritmeticaContext context)
        {
            Console.WriteLine($"visitando aritmetica: {context.GetText()}");
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] aritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine($"visitando expresion: { context.GetText()}");
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] aritmeticaParser.FactorContext context)
        {
            Console.WriteLine($"visitando factor: { context.GetText()}");
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] aritmeticaParser.TerminoContext context)
        {
            Console.WriteLine($"visitando Termino: { context.GetText()}");
            return base.VisitTermino(context);
        }
    }
}
