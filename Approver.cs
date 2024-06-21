namespace DesginPattern
{
    public abstract class Approver
    {
        protected Approver NextApprover;
        public void SetNextApprover(Approver nextApprover)
        {
            this.NextApprover = nextApprover;
        }
        public abstract bool ApproveMaterial(Material material, ref string reason);
    }
}