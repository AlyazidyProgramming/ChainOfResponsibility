using DesginPattern;

namespace ChainOfResposibilility
{
    public class PurchasingApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if (material.Budget < 10000)
            {
                //Allowd to purchasing to approve without back to Finance to approver
                reason = "Approverd was By purchases,";
                return true;
            }

            else if (material.Budget < 100000)
            {

                //in this example next approver is finanace class.
                //if budget > 10K need to finanace approve.
                if (NextApprover != null)
                {
                    return NextApprover.ApproveMaterial(material, ref reason);
                }

                return true;
            }
            else
            {
                //if budget more 100K you don't need to approve from any where or checkd is this simple example.
                reason = "Disapproverd by Boos Manger, not allowed to purchasing material than more 100,000";
                return false;
            }
        }
    }
}
