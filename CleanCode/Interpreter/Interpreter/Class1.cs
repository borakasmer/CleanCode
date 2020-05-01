using System;
using System.Collections.Generic;

namespace Interpreter
{
    public interface Expression
    {
        bool Interpret(string content);
    }

    public class CheckExpression : Expression
    {
        private string word;

        public CheckExpression(string _word)
        {
            this.word = _word;
        }

        public bool Interpret(string content)
        {
            return content.ToLower().Contains(word.ToLower());
        }
    }

    public class OrExpression : Expression
    {
        private Expression exp1;
        private Expression exp2;

        public OrExpression(Expression _exp1, Expression _exp2)
        {
            this.exp1 = _exp1;
            this.exp2 = _exp2;
        }
        public bool Interpret(string content)
        {
            return (exp1.Interpret(content) || exp2.Interpret(content));
        }
    }

    public class AndExpression : Expression
    {
        private Expression exp1;
        private Expression exp2;

        public AndExpression(Expression _exp1, Expression _exp2)
        {
            this.exp1 = _exp1;
            this.exp2 = _exp2;
        }
        public bool Interpret(string content)
        {
            return (exp1.Interpret(content) && exp2.Interpret(content));
        }
    }

    //public class And3Expression : Expression
    //{
    //    //çanta,ayakkabı,kuaför
    //    private Expression exp1;
    //    private Expression exp2;
    //    private Expression exp3;
    //    public And3Expression(Expression _exp1, Expression _exp2, Expression _exp3)
    //    {
    //        this.exp1 = _exp1;
    //        this.exp2 = _exp2;
    //        this.exp3 = _exp3;
    //    }
    //    public bool Interpret(string content)
    //    {
    //        return (exp1.Interpret(content) && exp2.Interpret(content) && exp3.Interpret(content));
    //    }
    //}

    public class InterpretPattern
    {
        public static Expression getMaleExpression()
        {
            Expression futbol = new CheckExpression("football");
            Expression araba = new CheckExpression("car");

            return new OrExpression(futbol, araba);
        }
        public static List<Expression> getFemailExpressions()
        {
            List<Expression> ListExpression = new List<Expression>();

            Expression mother = new CheckExpression("mother");
            Expression baby = new CheckExpression("baby");
            Expression rub = new CheckExpression("rub");
            Expression draw = new CheckExpression("draw");
            Expression car = new CheckExpression("car");
            
            ListExpression.Add(new OrExpression(mother, baby));
            ListExpression.Add(new AndExpression(rub, car));
            ListExpression.Add(new AndExpression(draw, car));
            return ListExpression;
        }       
    }
}
