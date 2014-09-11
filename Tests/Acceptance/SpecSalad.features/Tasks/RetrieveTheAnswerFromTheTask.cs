namespace SpecSalad.features.Tasks
{
    public class RetrieveTheAnswerFromTheTask :ApplicationTask
    {
        public override object Perform_Task()
        {
            return Role.GetStoredTaskAnswer();
        }
    }
}