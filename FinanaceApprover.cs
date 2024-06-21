using DesginPattern;

namespace ChainOfResposibilility
{
    public class FinanaceApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if (material.Budget < 100_000)
            {
                //in this chain this object is end of chain but this for later if you want to change the chain
                if (NextApprover != null)
                    return NextApprover.ApproveMaterial(material, ref reason);

                //Next will be null that's main this last approve.
                reason = "Approverd by Finance.";
                return true;

            }

            reason = $"cost of {material.Name} is very much sory we can not apporver in this time.";

            return false;

        }
    }
}