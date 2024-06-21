using DesginPattern;

namespace ChainOfResposibilility
{
    public class EngrenninerApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(material.DrawingNumber))
            {
                isValid = false;
                reason = "there is no drawing number for this materal!";
            }

            if (string.IsNullOrWhiteSpace(material.PartNumber))
            {
                isValid = false;
                reason = "there is no part number for this material!";

            }

            if (isValid)
            {

                if (NextApprover != null)
                {
                    return NextApprover.ApproveMaterial(material, ref reason);
                }
            }

            return isValid;
        }
    }
}