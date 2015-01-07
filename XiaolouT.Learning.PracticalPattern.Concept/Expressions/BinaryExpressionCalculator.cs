using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace XiaolouT.Learning.PracticalPattern.Concept.Expressions
{
    public class BinaryExpressionCalculator
    {
        Dictionary<ParameterExpression, double> m_argDict;
        readonly LambdaExpression m_exp;


        public BinaryExpressionCalculator(LambdaExpression exp)
        {
            m_exp = exp;
        }

        public double Calculate(params double[] args)
        {
            //从ExpressionExpression中提取参数，和传输的实参对应起来。
            //生成的字典可以方便我们在后面查询参数的值
            m_argDict = new Dictionary<ParameterExpression, double>();

            for (int i = 0; i < m_exp.Parameters.Count; i++)
            {
                //就不检查数目和类型了，大家理解哈
                m_argDict[m_exp.Parameters[i]] = args[i];
            }

            //提取树根
            var rootExp = m_exp.Body;

            //计算！
            return InternalCalc(rootExp);
        }

        double InternalCalc(Expression exp)
        {
            var cexp = exp as ConstantExpression;
            if (cexp != null) return (double)cexp.Value;

            var pexp = exp as ParameterExpression;
            if (pexp != null)
            {
                return m_argDict[pexp];
            }

            var bexp = exp as BinaryExpression;
            if (bexp == null) throw new ArgumentException("不支持表达式的类型", "exp");

            switch (bexp.NodeType)
            {
                case ExpressionType.Add:
                    return InternalCalc(bexp.Left) + InternalCalc(bexp.Right);
                case ExpressionType.Divide:
                    return InternalCalc(bexp.Left) / InternalCalc(bexp.Right);
                case ExpressionType.Multiply:
                    return InternalCalc(bexp.Left) * InternalCalc(bexp.Right);
                case ExpressionType.Subtract:
                    return InternalCalc(bexp.Left) - InternalCalc(bexp.Right);
                default:
                    throw new ArgumentException("不支持表达式的类型", "exp");
            }
        }
    }
}
