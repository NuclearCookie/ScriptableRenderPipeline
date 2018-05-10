using System;
namespace UnityEditor.VFX.Operator
{
    class Reciprocal : VFXOperatorUnaryFloatOperation
    {
        override public string name { get { return "Reciprocal (1/x) (deprecated)"; } }

        protected override sealed VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            var expression = inputExpression[0];
            return new[] { VFXOperatorUtility.OneExpression[expression.valueType] / expression };
        }

        public sealed override void Sanitize()
        {
            SanitizeHelper.SanitizeToOperatorNew(this, typeof(ReciprocalNew));
        }
    }
}
